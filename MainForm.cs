using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.OleDb;
using DevExpress.Utils;
using MiCLAS.MDE.Base;
using System.Globalization;
using System.Configuration;
using System.Reflection;

namespace MiCLAS.MDE
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        string strFormName = String.Empty;

        public MainForm()
        {
            InitializeComponent();

            AppearanceObject.DefaultFont = new Font(this.GetConfigurationValue("Font", "Tahoma"), float.Parse(this.GetConfigurationValue("FontSize", "15.75"), CultureInfo.InvariantCulture.NumberFormat));

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");

            PublicAttributes.DataConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Data\MDEInventur.mdb;User ID=admin";

            strFormName = this.Text;

            var timer = new Timer
            {
                Interval = 1000,
            };
            timer.Tick += (s, evt) =>
            {
                this.Text = this.strFormName + " - " + DateTime.Now.ToString();
            };
            timer.Start();
        }

        private void sbEnde_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbErfassungNeu_Click(object sender, EventArgs e)
        {
            if (CheckInventur() || MyXtraMessageBox.Show("ACHTUNG! Alle alten Daten werden gelöscht!\nEs existieren noch alte (nicht exportierte) Daten!\nSind sie sicher, dass Sie eine neue Erfassung starten wollen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteInventur();

                sbErfassungWeiter_Click(sender, e);
            }
        }

        private void sbErfassungWeiter_Click(object sender, EventArgs e)
        {
            int iBenutzer = -1;
            string strLager = String.Empty;

            bool result = false;

            using (BenutzerDlg bdlg = new BenutzerDlg())
            {
                if (bdlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    iBenutzer = bdlg.BenuzterNummer;
                    result = true;
                }
            }

            if (result)
            {
                using (LagerDlg ldlg = new LagerDlg())
                {
                    if (ldlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        strLager = ldlg.Lagerort;
                    }
                }
            }

            if (result)
            {
                result = iBenutzer > 0 && strLager != String.Empty;
            }

            if (result)
            {
                MainEditForm edit = new MainEditForm();

                edit.Benutzernummer = iBenutzer;
                edit.Lagerfach = strLager;

                edit.ShowDialog();
            }
        }





        private void sbArtikelImport_Click(object sender, EventArgs e)
        {
            string strFilename = String.Empty;
            bool result = true;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MDE-Artikel|ART*.DAT|Alle Dateien|*.*";
                ofd.FileName = "ART.DAT";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strFilename = ofd.FileName;
                }
            }

            if (strFilename != String.Empty && File.Exists(strFilename))
            {
                using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OleDbCommand cmd = new OleDbCommand("DELETE FROM MDEArtikel", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MyXtraMessageBox.Show("Artikel Import: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }

                if (result)
                {
                    Cursor = Cursors.WaitCursor;

                    List<string> listSatz = new List<string>();
                    string line = String.Empty;

                    using (TextReader reader = new StreamReader(strFilename, Encoding.Default))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            listSatz.Add(line);
                        }
                    }

                    string[] sSatz = null;

                    using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            for (System.Collections.IEnumerator enumSatz = listSatz.GetEnumerator(); result && enumSatz.MoveNext();)
                            {
                                if ((string)enumSatz.Current != String.Empty)
                                {
                                    sSatz = ((string)enumSatz.Current).Split(';');

                                    string strSQL = "INSERT INTO MDEArtikel (Artikelnummer, Bezeichnung1, Mengeneinheit1, Mengeneinheit2, Abmassfeld1, Abmassfeld2, Abmassfeld3, Abmassfeld4, Seriennummernpflichtig, Chargenpflichtig, Ursprungslandpflichtig, EANCode, Barcode, EDICode) VALUES (";
                                    strSQL += "@Artikelnummer, @Bezeichnung1, @Mengeneinheit1, @Mengeneinheit2, @Abmassfeld1, @Abmassfeld2, @Abmassfeld3, @Abmassfeld4, @Seriennummernpflichtig, @Chargenpflichtig, @Ursprungslandpflichtig, @EANCode, @Barcode, @EDICode)";

                                    using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@Artikelnummer", sSatz[0]);
                                        cmd.Parameters.AddWithValue("@Bezeichnung1", sSatz[1]);
                                        cmd.Parameters.AddWithValue("@Mengeneinheit1", sSatz[2]);
                                        cmd.Parameters.AddWithValue("@Mengeneinheit2", sSatz[3]);
                                        cmd.Parameters.AddWithValue("@Abmassfeld1", sSatz[4]);
                                        cmd.Parameters.AddWithValue("@Abmassfeld2", sSatz[5]);
                                        cmd.Parameters.AddWithValue("@Abmassfeld3", sSatz[6]);
                                        cmd.Parameters.AddWithValue("@Abmassfeld4", sSatz[7]);
                                        cmd.Parameters.AddWithValue("@Seriennummernpflichtig", sSatz[8] == "1" ? 1 : 0);
                                        cmd.Parameters.AddWithValue("@Chargenpflichtig", sSatz[9] == "1" ? 1 : 0);
                                        cmd.Parameters.AddWithValue("@Ursprungslandpflichtig", sSatz[10] == "1" ? 1 : 0);
                                        cmd.Parameters.AddWithValue("@EANCode", sSatz[11]);
                                        cmd.Parameters.AddWithValue("@Barcode", sSatz[12]);
                                        cmd.Parameters.AddWithValue("@EDICode", sSatz[13]);

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MyXtraMessageBox.Show("Datei Fehlerhaft! Import abgebrochen!");
                            result = false;
                        }
                        finally
                        {
                            if (conn.State != ConnectionState.Closed)
                            {
                                conn.Close();
                            }
                        }
                    }
                    if (result)
                        MyXtraMessageBox.Show("Artikel erfolgreich importiert!");
                    else
                        MyXtraMessageBox.Show("Keine Artikel eingelesen!");

                }
            }
            else
            {
                XtraMessageBox.Show("Datei nicht vorhanden");
            }

            Cursor = Cursors.Default;
        }

        private void sbErfassungExport_Click(object sender, EventArgs e)
        {
            string strGeraet = "XXX";
            string strExportName = String.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        string strSQL = "SELECT Geraetenummer FROM MDEGeraet ORDER BY Geraetenummer";

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        {
                            object obj = cmd.ExecuteScalar();

                            if (obj != null && !Convert.IsDBNull(obj))
                            {
                                strGeraet = String.Format("{0:000}", obj);
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Fehler beim Öffnen der Datenbank");
                    }
                    finally
                    {
                        if (conn.State != ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }
                }

                DataTable dtInventur = new DataTable("MDEInventur)");

                using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        string strSQL = "SELECT * FROM MDEInventur";

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            dtInventur.Load(reader);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Fehler beim Öffnen der Datenbank");
                    }
                    finally
                    {
                        if (conn.State != ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }
                }




                dtInventur.DefaultView.Sort = "LagerGruppe,Lagerort,Magazin,Artikelnummer,Charge,Seriennummer,Menge1,Menge2,Abmassfeld1,Abmassfeld2,Abmassfeld3,Abmassfeld4,Herstelldatum, Verfallsdatum";

                strExportName = Path.Combine(Application.StartupPath, "Export", "INV" + strGeraet + DateTime.Now.ToString("yyyyMMddhhmmss") + ".DAT");

                if (!Directory.Exists(Path.Combine(Application.StartupPath, "Export")))
                {
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Export"));
                }

                List<string> listSatz = new List<string>();
                StringBuilder sbSatz = new StringBuilder();

                DataRow rowInv = null;

                for (System.Collections.IEnumerator enumInv = dtInventur.DefaultView.GetEnumerator(); enumInv.MoveNext(); )
                {
                    rowInv = ((DataRowView)enumInv.Current).Row;

                    string Benutzernummer = String.Empty;
                    string Lagergruppe = String.Empty;
                    string Lagerort = String.Empty;
                    string Magazin = String.Empty;
                    string Artikelnummer = String.Empty;
                    string Herstelldatum = string.Empty;
                    string verfallsdatum = string.Empty;

                    double Menge1 = 0.0;
                    double Menge2 = 0.0;
                    double Abmassfeld1 = 0.0;
                    double Abmassfeld2 = 0.0;
                    double Abmassfeld3 = 0.0;
                    double Abmassfeld4 = 0.0;

                    string Seriennummer = String.Empty;
                    string Charge = String.Empty;
                    string Datum = String.Empty;
                    string Ursprungsland = String.Empty;

                    Benutzernummer = rowInv.GetIntValue("Benutzernummer").ToString();
                    Lagergruppe = rowInv.GetStringValue("Lagergruppe");
                    Lagerort = rowInv.GetStringValue("Lagerort");
                    Magazin = rowInv.GetStringValue("Magazin");
                    Artikelnummer = rowInv.GetStringValue("Artikelnummer");
                
                
                    Menge1 = rowInv.GetDoubleValue("Menge1");
                    Menge2 = rowInv.GetDoubleValue("Menge2");
                    Abmassfeld1 = rowInv.GetDoubleValue("Abmassfeld1");
                    Abmassfeld2 = rowInv.GetDoubleValue("Abmassfeld2");
                    Abmassfeld3 = rowInv.GetDoubleValue("Abmassfeld3");
                    Abmassfeld4 = rowInv.GetDoubleValue("Abmassfeld4");

                    Seriennummer = rowInv.GetStringValue("Seriennummer");
                    Charge = rowInv.GetStringValue("Charge");
                    Ursprungsland = rowInv.GetStringValue("Ursprungsland");
                    if (!rowInv.IsDateNull("Datum"))
                        Datum = rowInv.GetDateValue("Datum").ToString("yyyyMMddHHmmss");
                    else
                        Datum = DateTime.Now.ToString("yyyyMMddHHmmss");
                    if (!rowInv.IsDateNull("Herstelldatum"))
                        Herstelldatum = rowInv.GetDateValue("Herstelldatum").ToString("yyyyMMddHHmmss");
                    else
                        Herstelldatum = "";

                    if (!rowInv.IsDateNull("Verfallsdatum"))
                        verfallsdatum = rowInv.GetDateValue("Verfallsdatum").ToString("yyyyMMddHHmmss");
                    else
                        verfallsdatum = "";

                    sbSatz.Clear();
                    sbSatz.Append(Benutzernummer);
                    sbSatz.Append(";");
                    sbSatz.Append(Lagergruppe);
                    sbSatz.Append(";");
                    sbSatz.Append(Lagerort);
                    sbSatz.Append(";");
                    sbSatz.Append(Magazin);
                    sbSatz.Append(";");
                    sbSatz.Append(Artikelnummer);
                    sbSatz.Append(";");
                    sbSatz.Append(Menge1.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));
                    sbSatz.Append(";");
                    sbSatz.Append(Menge2.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));
                    sbSatz.Append(";");
                    
                    if (Abmassfeld1 > 0.0)
                        sbSatz.Append(Abmassfeld1.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));
                    sbSatz.Append(";");
                    
                    if (Abmassfeld2 > 0.0)
                        sbSatz.Append(Abmassfeld2.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));
                    sbSatz.Append(";");
                    
                    if (Abmassfeld3 > 0.0)
                        sbSatz.Append(Abmassfeld3.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));
                    sbSatz.Append(";");
                    
                    if (Abmassfeld4 > 0.0)
                        sbSatz.Append(Abmassfeld4.ToString("N3", CultureInfo.InvariantCulture).Replace(",", ""));                    
                    sbSatz.Append(";");

                    if (!String.IsNullOrEmpty(Herstelldatum))
                    {
                        sbSatz.Append(Herstelldatum);
                        sbSatz.Append(";");
                    }
                    if (!String.IsNullOrEmpty(verfallsdatum))
                    {
                        sbSatz.Append(verfallsdatum);
                        sbSatz.Append(";");
                    }
                    sbSatz.Append(Seriennummer);
                    sbSatz.Append(";");
                    
                    sbSatz.Append(Charge);
                    sbSatz.Append(";");

                    if (!String.IsNullOrEmpty(Ursprungsland))
                    {
                        sbSatz.Append(Ursprungsland);
                        sbSatz.Append(";");
                    }

                    sbSatz.Append(Datum);

                    listSatz.Add(sbSatz.ToString());
                }

                if (listSatz.Count > 0)
                {
                    using (TextWriter tw = new StreamWriter(strExportName, false, Encoding.Default))
                    {
                        foreach (string s in listSatz)
                        {
                            tw.WriteLine(s);
                        }
                    }

                    string strMessage = "Daten erfolgreich exportiert!";
                    strMessage += Environment.NewLine;
                    strMessage += "Sollen die exportierten Daten jetzt aus der Erfassung gelöscht werden?";

                    if (MyXtraMessageBox.Show(strMessage, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        DeleteInventur();
                    }
                }
            }
            catch (Exception ex)
            {
                MyXtraMessageBox.Show("Export Artikel: " + ex.Message);
            }
        }

        private void DeleteInventur()
        {
            using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM MDEInventur", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    MyXtraMessageBox.Show("Delete Import: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private bool CheckInventur()
        {
            bool result = true;
            using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    string strSQL = "SELECT COUNT(*) FROM MDEInventur";

                    using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                    {
                        object obj = cmd.ExecuteScalar();

                        if (obj != null)
                        {
                            result = Convert.ToInt32(obj) == 0;
                        }

                    }
                }
                catch
                {
                    XtraMessageBox.Show("Fehler beim Öffnen der Datenbank");
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }

            return result;

            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Clock
            this.Text = this.strFormName + " - " + DateTime.Now.ToString();         
        }

        #region Config

        public bool GetConfigurationBoolValue(string key, bool defaultValue = false)
        {
            string result = GetConfigurationValue(key);

            if (!String.IsNullOrEmpty(result))
            {
                bool.TryParse(result, out defaultValue);
            }

            return defaultValue;
        }

        public int GetConfigurationIntValue(string key, int defaultValue = 0)
        {
            string result = GetConfigurationValue(key);

            if (!String.IsNullOrEmpty(result))
            {
                int.TryParse(result, out defaultValue);
            }

            return defaultValue;
        }

        public string GetConfigurationValue(string key, string defaultValue = "")
        {
            Assembly service = Assembly.GetAssembly(typeof(MainForm));

            Configuration config = null;

            // Default
            config = ConfigurationManager.OpenExeConfiguration(service.Location);

            if (config.AppSettings.Settings[key] != null)
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            {
                return defaultValue;
                //throw new IndexOutOfRangeException("Settings collection does not contain the requested key:" + key);
            }
        }

        #endregion Config
    }
}