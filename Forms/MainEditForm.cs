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
using DevComponents.DotNetBar.Keyboard;
using MiCLAS.MDE.Base;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Globalization;
using System.Collections.Specialized;
using DevExpress.XtraLayout;

namespace MiCLAS.MDE
{
    public partial class MainEditForm : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
    {
        # region Properties     

        List<Control> listControlTab = null;

        MDEModus _MDEModus = MDEModus.Artikelnummer;
        string _DefaultInventurFilter = String.Empty;

        int _Benutzernummer = -1;

        public int Benutzernummer
        {
            get { return _Benutzernummer; }
            set { _Benutzernummer = value; NotifyPropertyChanged("Benutzernummer"); }
        }

        string _Lagerfach = String.Empty;

        public string Lagerfach
        {
            get { return _Lagerfach; }
            set { _Lagerfach = value; NotifyPropertyChanged("Lagerfach"); }
        }
        string _ArtBezeichnung = String.Empty;


        string _Artikelnummer = String.Empty;

        public string Artikelnummer
        {
            get { return _Artikelnummer; }
            set { _Artikelnummer = value; NotifyPropertyChanged("Artikelnummer"); }
        }

        public string ArtBezeichnung
        {
            get { return _ArtBezeichnung; }
            set { _ArtBezeichnung = value; NotifyPropertyChanged("ArtBezeichnung"); }
        }
        string _InputField = String.Empty;

        public string InputField
        {
            get { return _InputField; }
            set { _InputField = value; NotifyPropertyChanged("InputField"); }
        }
        string _Charge = String.Empty;

        public string Charge
        {
            get { return _Charge; }
            set { _Charge = value; NotifyPropertyChanged("Charge"); }
        }

        string _Ursprungsland = String.Empty;

        public string Ursprungsland
        {
            get { return _Ursprungsland; }
            set { _Ursprungsland = value; NotifyPropertyChanged("Ursprungsland"); }
        }


        double _Menge1 = 0.0;

        public double Menge1
        {
            get { return _Menge1; }
            set { _Menge1 = value; NotifyPropertyChanged("Menge1"); }
        }
        double _Menge2 = 0.0;

        public double Menge2
        {
            get { return _Menge2; }
            set { _Menge2 = value; NotifyPropertyChanged("Menge2"); }
        }

        object _Abmassfeld1 = DBNull.Value;

        public object Abmassfeld1
        {
            get { return _Abmassfeld1; }
            set { _Abmassfeld1 = value; NotifyPropertyChanged("Abmassfeld1"); }
        }
        object _Abmassfeld2 = DBNull.Value;

        public object Abmassfeld2
        {
            get { return _Abmassfeld2; }
            set { _Abmassfeld2 = value; NotifyPropertyChanged("Abmassfeld2"); }
        }
        object _Abmassfeld3 = DBNull.Value;

        public object Abmassfeld3
        {
            get { return _Abmassfeld3; }
            set { _Abmassfeld3 = value; NotifyPropertyChanged("Abmassfeld3"); }
        }
        object _Abmassfeld4 = DBNull.Value;

        public object Abmassfeld4
        {
            get { return _Abmassfeld4; }
            set { _Abmassfeld4 = value; NotifyPropertyChanged("Abmassfeld4"); }
        }

        string _Menge1Text = String.Empty;

        public string Menge1Text
        {
            get { return _Menge1Text; }
            set { _Menge1Text = value; NotifyPropertyChanged("Menge1Text"); }
        }
        string _Menge2Text = String.Empty;

        public string Menge2Text
        {
            get { return _Menge2Text; }
            set { _Menge2Text = value; NotifyPropertyChanged("Menge2Text"); }
        }
        string _Abmassfeld1Text = String.Empty;

        public string Abmassfeld1Text
        {
            get { return _Abmassfeld1Text; }
            set { _Abmassfeld1Text = value; NotifyPropertyChanged("Abmassfeld1Text"); }
        }
        string _Abmassfeld2Text = String.Empty;

        public string Abmassfeld2Text
        {
            get { return _Abmassfeld2Text; }
            set { _Abmassfeld2Text = value; NotifyPropertyChanged("Abmassfeld2Text"); }
        }
        string _Abmassfeld3Text = String.Empty;

        public string Abmassfeld3Text
        {
            get { return _Abmassfeld3Text; }
            set { _Abmassfeld3Text = value; NotifyPropertyChanged("Abmassfeld3Text"); }
        }
        string _Abmassfeld4Text = String.Empty;

        public string Abmassfeld4Text
        {
            get { return _Abmassfeld4Text; }
            set { _Abmassfeld4Text = value; NotifyPropertyChanged("Abmassfeld4Text"); }
        }
        DateTime _Herstelldatum = DateTime.Now;

        public DateTime Herstelldatum
        {
            get { return _Herstelldatum; }
            set { _Herstelldatum = value; NotifyPropertyChanged("Herstelldatum"); }
        }

        DateTime _Verfallsdatum = DateTime.Now;

        public DateTime Verfallsdatum
        {
            get { return _Verfallsdatum; }
            set { _Verfallsdatum = value; NotifyPropertyChanged("Verfallsdatum"); }
        }


        string SeriennummerStr = String.Empty;

        public string Seriennummer
        {
            get { return SeriennummerStr; }
            set { SeriennummerStr = value; NotifyPropertyChanged("Seriennummer"); }
        }


        bool _Seriennummer = false;


        double _MengeGezaehlt = 0.0;

        public double MengeGezaehlt
        {
            get { return _MengeGezaehlt; }
            set { _MengeGezaehlt = value; NotifyPropertyChanged("MengeGezaehlt"); }
        }

        double _MengeGezaehlt2 = 0.0;

        public double MengeGezaehlt2
        {
            get { return _MengeGezaehlt2; }
            set { _MengeGezaehlt2 = value; NotifyPropertyChanged("MengeGezaehlt2"); }
        }

        string strFormName = String.Empty;


        #endregion Properties

        #region Constructor

        public MainEditForm()
        {
            InitializeComponent();

            this.listControlTab = new List<Control>();

            this.listControlTab.Add(this.tbMenge1);
            this.listControlTab.Add(this.tbMenge2);
            this.listControlTab.Add(this.tbAb1);
            this.listControlTab.Add(this.tbAb2);
            this.listControlTab.Add(this.tbAb3);
            this.listControlTab.Add(this.tbAb4);

            this.strFormName = this.Text;

            this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateAZ19KeyboardEx();
            this.keyboardControlNum.Invalidate();



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

        #endregion Constructor

        #region overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.lbBenuzter.Text = GetNutzerName();

            this.lcLager.DataBindings.Add("Text", this, "Lagerfach");
            this.lcBezeichnung.DataBindings.Add("Text", this, "ArtBezeichnung");
            this.lcArtikelnummer.DataBindings.Add("Text", this, "Artikelnummer");
            this.lcMengeGezaeht.DataBindings.Add("Text", this, "MengeGezaehlt", true, DataSourceUpdateMode.OnPropertyChanged, "", "N3");
            this.lcMengeGezaeht2.DataBindings.Add("Text", this, "MengeGezaehlt2", true, DataSourceUpdateMode.OnPropertyChanged, "", "N3");

            this.tbInput.DataBindings.Add("EditValue", this, "InputField");
            this.tbCharge.DataBindings.Add("EditValue", this, "Charge");
            this.tbMenge1.DataBindings.Add("EditValue", this, "Menge1");
            this.tbMenge2.DataBindings.Add("EditValue", this, "Menge2");
            this.tbAb1.DataBindings.Add("EditValue", this, "Abmassfeld1");
            this.tbAb2.DataBindings.Add("EditValue", this, "Abmassfeld2");
            this.tbAb3.DataBindings.Add("EditValue", this, "Abmassfeld3");
            this.tbAb4.DataBindings.Add("EditValue", this, "Abmassfeld4");

            this.tbHerstelldatum.DataBindings.Add("EditValue", this, "Herstelldatum");
            this.tbVerfallsdatum.DataBindings.Add("EditValue", this, "Verfallsdatum");


            this.sllMenge1.DataBindings.Add("Text", this, "Menge1Text");
            this.sllMenge2.DataBindings.Add("Text", this, "Menge2Text");
            this.lciTbAb1.DataBindings.Add("Text", this, "Abmassfeld1Text");
            this.lciTbAb2.DataBindings.Add("Text", this, "Abmassfeld2Text");
            this.lciTbAb3.DataBindings.Add("Text", this, "Abmassfeld3Text");
            this.lciTbAb4.DataBindings.Add("Text", this, "Abmassfeld4Text");

            this.tbLand.DataBindings.Add("EditValue", this, "Ursprungsland");
            this.InitFields();
            this.SetMDEModus();
            //this.ReadArtikel();

            this.BeginInvoke(new Action(delegate
            {
                InvokeFocus();
            }));
        }

        private string GetNutzerName()
        {
            string strReturn = String.Empty;

            using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    string strSQL = String.Format("SELECT Benutzername FROM MDEBenutzer WHERE Benutzernummer = {0}", this.Benutzernummer);

                    using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                    {
                        object obj = cmd.ExecuteScalar();

                        if (obj != null && !Convert.IsDBNull(obj))
                        {
                            strReturn = obj.ToString();
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

            return strReturn;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        # endregion overrides


        private void InitFields()
        {
            this.ArtBezeichnung = String.Empty;
            this.InputField = String.Empty;
            this.Charge = String.Empty;
            this.Herstelldatum = DateTime.Now;
            this.Verfallsdatum = DateTime.Now;
            this.Ursprungsland = String.Empty;
            this.Menge1 = 0.0;
            this.Menge2 = 0.0;
            this.Abmassfeld1 = DBNull.Value;
            this.Abmassfeld2 = DBNull.Value;
            this.Abmassfeld3 = DBNull.Value;
            this.Abmassfeld4 = DBNull.Value;
            this.Menge1Text = String.Empty;
            this.Menge2Text = String.Empty;
            this.Abmassfeld1Text = String.Empty;
            this.Abmassfeld2Text = String.Empty;
            this.Abmassfeld3Text = String.Empty;
            this.Abmassfeld4Text = String.Empty;
            this.MengeGezaehlt = 0.0;
            this.MengeGezaehlt2 = 0.0;
            this.lcMengeGezaeht.Appearance.Image = Properties.Resources.Apply_32x32;
            this.lcMengeGezaeht2.Appearance.Image = Properties.Resources.Apply_32x32;

            this.lciTbMenge1.AppearanceItemCaption.Reset();
            this.lciTbMenge2.AppearanceItemCaption.Reset();

            this.lciTbCharge.ContentVisible = false;
            this.lciTbMenge2.ContentVisible = false;
            this.lciLcMengeGezaeht2.ContentVisible = false;
            this.lciTbAb1.ContentVisible = false;
            this.lciTbAb2.ContentVisible = false;
            this.lciTbAb3.ContentVisible = false;
            this.lciTbAb4.ContentVisible = false;
            this.lciLand.ContentVisible = false;
            this.lciTbVerfallsdatum.ContentVisible = false;
            this.lciTbHerstelldatum.ContentVisible = false;
            this.sllMenge2.ContentVisible = false;

            this.Artikelnummer = String.Empty;
            this._Seriennummer = false;

            this.tbInput.Properties.ReadOnly = false;
            this.Seriennummer = string.Empty;
        }

        private void SetMDEModus()
        {
            using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    string strSQL = "SELECT Modus FROM MDEGeraet ORDER BY Geraetenummer";

                    using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                    {
                        object obj = cmd.ExecuteScalar();

                        if (obj != null && !Convert.IsDBNull(obj))
                        {
                            this._MDEModus = (MDEModus)Convert.ToInt32(obj);
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

            switch (this._MDEModus)
            {
                case MDEModus.Artikelnummer:
                    this.tbInput.Properties.CharacterCasing = CharacterCasing.Upper;
                    this.tbInput.Properties.NullValuePrompt = "Bitte Artikelnummer scannen";
                    this._DefaultInventurFilter = "Artikelnummer = '{0}'";
                    this.tbInput.Properties.MaxLength = 60;
                    break;
                case MDEModus.Barcode:
                    this.tbInput.Properties.NullValuePrompt = "Bitte Barcode scannen";
                    this._DefaultInventurFilter = "Barcode = '{0}'";
                    this.tbInput.Properties.MaxLength = 60;
                    break;
                case MDEModus.EAN:
                    this.tbInput.Properties.NullValuePrompt = "Bitte EAN-Code scannen";
                    this._DefaultInventurFilter = "EANCode = '{0}'";
                    this.tbInput.Properties.MaxLength = 40;
                    break;
                case MDEModus.EDI:
                    this.tbInput.Properties.NullValuePrompt = "Bitte EDI-Code scannen";
                    this._DefaultInventurFilter = "EDICode = '{0}'";
                    this.tbInput.Properties.MaxLength = 60;
                    break;
            }
        }

        //private void ReadArtikel()
        //{
        //    using (MDEArtikelTableAdapter adapter = new MDEArtikelTableAdapter())
        //    {
        //        adapter.Fill(this.MDEInventurDataSet.MDEArtikel);
        //    }
        //}

        private void SaveDaten()
        {
            if (this._Artikelnummer != String.Empty && (this.Menge1 != 0.0 || this.Menge2 != 0.0))
            {
                Cursor = Cursors.WaitCursor;

                if (this._Seriennummer)
                {
                    using (SeriennummernForm sf = new SeriennummernForm())
                    {
                        sf.Total = Convert.ToInt32(this.Menge1);
                        sf.Artikelnummer = this._Artikelnummer;
                        if (!string.IsNullOrEmpty(this.Seriennummer))// just one serialnummber from gs1 
                        {
                            sf.Total = 1;
                            SaveDaten(this.Seriennummer);

                        }
                        else 
                        {
                            sf.ShowDialog();

                            foreach (string s in sf.Seriennummern)
                            {
                                SaveDaten(s);
                            }

                        }
                    }
                }
                else
                {
                    SaveDaten(String.Empty);
                }
            }

            Cursor = Cursors.Default;
        }

        private void SaveDaten(string strSeriennummer)
        {

            string strLager = String.Empty;
            string strLagerort = String.Empty;
            string strMagazin = String.Empty;

            string[] s = this.Lagerfach.Split('#');
            if (s.Length < 2)
                s = this.Lagerfach.Split('.');

            if (s.Length >= 2)
            {
                strLager = s[0].Trim();
                strLagerort = s[1].Trim();
            }

            if (s.Length == 3)
            {
                strMagazin = s[2].Trim();
            }

            string strSQL = "INSERT INTO MDEInventur (Benutzernummer, Lagergruppe,Lagerort, Magazin, Artikelnummer, Menge1, Menge2,Datum, Abmassfeld1,Abmassfeld2, Abmassfeld3, Abmassfeld4, Charge, Ursprungsland, Seriennummer ,Herstelldatum,Verfallsdatum) VALUES (";

            double dTmpMenge = this.Menge1;

            if (strSeriennummer != String.Empty)
            {
                dTmpMenge = 1;
            }


            double ab1 = 0.0;
            double ab2 = 0.0;
            double ab3 = 0.0;
            double ab4 = 0.0;
            
            if (this.Abmassfeld1 != null && !Convert.IsDBNull(this.Abmassfeld1))
            {
                ab1 = Convert.ToDouble(this.Abmassfeld1);
            }

            if (this.Abmassfeld2 != null && !Convert.IsDBNull(this.Abmassfeld2))
            {
                ab2 = Convert.ToDouble(this.Abmassfeld2);
            }

            if (this.Abmassfeld3 != null && !Convert.IsDBNull(this.Abmassfeld3))
            {
                ab3 = Convert.ToDouble(this.Abmassfeld3);
            }

            if (this.Abmassfeld4 != null && !Convert.IsDBNull(this.Abmassfeld4))
            {
                ab4 = Convert.ToDouble(this.Abmassfeld4);
            }
            
            strSQL += this.Benutzernummer + ",";
            strSQL += "'" + strLager + "' ,";
            strSQL += "'" + strLagerort + "' ,";
            strSQL += "'" + strMagazin + "' ,";
            strSQL += "'" + this._Artikelnummer + "' ,";
            strSQL += dTmpMenge.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += this.Menge2.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,";
            strSQL += ab1.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += ab2.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += ab3.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += ab4.ToString(CultureInfo.InvariantCulture) + ",";
            strSQL += "'" + this.Charge + "',";
            strSQL += "'" + this.Ursprungsland + "',";
            strSQL += "'" + strSeriennummer + "',";
            if (this.lciTbHerstelldatum.ContentVisible)
                strSQL += "'" + this.Herstelldatum.ToString("MM.dd.yyyy") + "',";
            else strSQL += "'" + " 00:0:00" + "',";
            if (this.lciTbVerfallsdatum.ContentVisible)
                strSQL += "'" + this.Verfallsdatum.ToString("MM.dd.yyyy") + "')";
            else  strSQL += "'" + " 00:0:00" + "')";

            using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
            {
                conn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Fehler beim Öffnen der Datenbank: " + ex.Message);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }


        internal void SwitchKeyboard(bool bNum)
        {
            if (bNum)
            {
                this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateNumericKeyboard();
                this.keyboardControlNum.Invalidate();
            }
            else
            {
                this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateAZ19KeyboardEx();
                this.keyboardControlNum.Invalidate();
            }
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// property change event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// runs PropertyChanged-event
        /// </summary>
        /// <param name="info">name of property, which has been changed</param>
        protected virtual void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion

        # region events

        private void tbInput_Validating(object sender, CancelEventArgs e)
        {
            bool bCharge = false;
            bool bLand = false;
            bool result = false;
            string input = this.tbInput.EditValue.ToString();
           
            if (input != String.Empty)
            {

                InputData input1 = new InputData();
                if (input1.Istvalid(input, _DefaultInventurFilter))
                {
                    this.Artikelnummer = input1.ArtikelnummerInput;
                    this.ArtBezeichnung = input1.ArtBezeichnungInput;
                    this.Menge1Text = input1.Menge1TextInput;
                    this.Menge2Text = input1.Menge2TextInput; ;
                    this.Abmassfeld1Text = input1.Abmassfeld1TextInput;
                    this.Abmassfeld2Text = input1.Abmassfeld2TextInput;
                    this.Abmassfeld3Text = input1.Abmassfeld3TextInput;
                    this.Abmassfeld4Text = input1.Abmassfeld4TextInput;
                    this.Seriennummer = input1.Seriennummer;
                    this._Seriennummer = input1._SeriennummerInput;
                    bCharge = input1.bCharge;
                    bLand = input1.bLand;
                    result = true;
                }
                else if (input1.isGs1(input))
                    if (input1.Istvalid(input1.ArtikelnummerInput, _DefaultInventurFilter))
                    {
                        this.Artikelnummer = input1.ArtikelnummerInput;
                        this.ArtBezeichnung = input1.ArtBezeichnungInput;
                        this.Menge1Text = input1.Menge1TextInput;
                        this.Menge2Text = input1.Menge2TextInput; ;
                        this.Abmassfeld1Text = input1.Abmassfeld1TextInput;
                        this.Abmassfeld2Text = input1.Abmassfeld2TextInput;
                        this.Abmassfeld3Text = input1.Abmassfeld3TextInput;
                        this.Abmassfeld4Text = input1.Abmassfeld4TextInput;
                        this._Seriennummer = input1._SeriennummerInput;
                        bCharge = input1.bCharge;
                        bLand = input1.bLand;
                        if (bLand)
                            this.Ursprungsland = input1.UrsprungslandInput;
                        if (this._Seriennummer)
                            this.Seriennummer = input1.Seriennummer;
                        if (bCharge)
                            this.Charge = input1.ChargeInput;
                        this.Menge1 = input1.Menge1;
                        if (!string.IsNullOrEmpty(input1.HerstelldatumInput))
                            this.Herstelldatum = DateTime.Parse(input1.HerstelldatumInput);
                        if (!string.IsNullOrEmpty(input1.VerfallsdatumInput))
                            this.Verfallsdatum = DateTime.Parse(input1.VerfallsdatumInput);
                       
                        result = true;
                    }


                bool bShow = this.Abmassfeld1Text != String.Empty;

                this.lciTbAb1.ContentVisible = bShow;
                bShow = this.Abmassfeld2Text != String.Empty;

                this.lciTbAb2.ContentVisible = bShow;

                bShow = this.Abmassfeld3Text != String.Empty;

                this.lciTbAb3.ContentVisible = bShow;

                bShow = this.Abmassfeld4Text != String.Empty;

                this.lciTbAb4.ContentVisible = bShow;

                bShow = this.Menge2Text != String.Empty;

                this.lciTbMenge2.ContentVisible = bShow;
                this.sllMenge2.ContentVisible = bShow;
                this.lciLcMengeGezaeht2.ContentVisible = bShow;

                bShow = bCharge;

                this.lciTbCharge.ContentVisible = bShow;

                bShow = bLand;

                this.lciLand.ContentVisible = bShow;
                if (!string.IsNullOrEmpty(this.Seriennummer))
                {
                    this.lciTbMenge1.Enabled = false;
                    this.Menge1 = 1;
                }
                else this.lciTbMenge1.Enabled = true;
         
               if(bLand || bCharge)
                {
                    bShow = true;
                    this.lciTbHerstelldatum.ContentVisible = bShow;
                    this.lciTbVerfallsdatum.ContentVisible = bShow;
                }
       

                this.InputField = input;

                if (result)
                {
                    this.tbInput.Properties.ReadOnly = true;

                    using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                    {
                        conn.Open();

                        string strSQL = String.Format("SELECT SUM(Menge1) AS Gesamt FROM MDEInventur WHERE Artikelnummer = '{0}'", this.Artikelnummer);

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        {
                            object obj = cmd.ExecuteScalar();

                            if (obj != null && !Convert.IsDBNull(obj))
                            {
                                this.MengeGezaehlt = Convert.ToDouble(obj);
                            }
                        }

                        strSQL = String.Format("SELECT SUM(Menge2) AS Gesamt FROM MDEInventur WHERE Artikelnummer = '{0}'", this.Artikelnummer);

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        {
                            object obj = cmd.ExecuteScalar();

                            if (obj != null && !Convert.IsDBNull(obj))
                            {
                                this.MengeGezaehlt2 = Convert.ToDouble(obj);
                            }
                        }

                        conn.Close();
                    }

                    if (this.MengeGezaehlt > 0.0)
                    {
                        this.lcMengeGezaeht.Appearance.Image = Properties.Resources.Cancel_32x32;

                        this.lciTbMenge1.AppearanceItemCaption.ForeColor = Color.Red;
                    }

                    if (this.MengeGezaehlt2 > 0.0)
                    {
                        this.lcMengeGezaeht2.Appearance.Image = Properties.Resources.Cancel_32x32;

                        this.lciTbMenge2.AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }

                if (result)
                {
                    if (this.lciTbCharge.ContentVisible)
                        this.tbCharge.Focus();
                    else if(this.lciLand.ContentVisible)
                        this.tbLand.Focus();
                    else
                        this.tbMenge1.Focus();
                }
            }

            e.Cancel = !result;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyData == Keys.Tab)
            {
                if (this.ActiveControl == this.mainLayoutControl &&
                    ((LayoutControl)this.ActiveControl).ActiveControl == this.btnSpeichern)
                {
                    SaveDaten();
                    InitFields();

                    this.BeginInvoke(new Action(delegate
                    {
                        InvokeFocus();
                    }));
                }
            }
        }

        private void tbField_Validated(object sender, EventArgs e)
        {
            //if (bTab)
            //{
            //    if (this.listControlTab.Contains((Control)sender))
            //    {
            //        int iPos = this.listControlTab.IndexOf((Control)sender);

            //        bool bSave = false;

            //        bSave = iPos == this.listControlTab.Count - 1;

            //        if (!bSave)
            //        {
            //            bSave = true;
            //            for (int i = iPos + 1; i < this.listControlTab.Count; i++)
            //            {
            //                if (this.listControlTab[i].Visible)
            //                {
            //                    bSave = false;
            //                    break;
            //                }
            //            }
            //        }

            //        if (bSave)
            //        {
            //            SaveDaten();
            //            InitFields();

            //            this.BeginInvoke(new Action(delegate
            //            {
            //                InvokeFocus();
            //            }));
            //        }
            //    }
            //}


            //bTab = false;

            //Control find = (Control)sender;

            //bool bFind = false;
            //while (!bFind)
            //{
            //    find = this.GetNextControl(find, true);

            //    if (find is CustomTextEdit &&
            //        find.Visible)
            //    {
            //        bFind = true;
            //    }
            //    else if (find is SimpleButton)
            //    {
            //        bFind = true;
            //    }
            //    else if (find == null)
            //    {
            //        break;
            //    }
            //}

            //if (bFind)
            //{
            //    if (find == btnSpeichern)
            //    {
            //        SaveDaten();
            //        InitFields();

            //        this.BeginInvoke(new Action(delegate
            //        {
            //            InvokeFocus();
            //        }));
            //    }
            //}
        }

        void InvokeFocus()
        {
            this.tbInput.Focus();
        }

        int iError = 0;


        private void tbField_Validating(object sender, CancelEventArgs e)
        {
            if (this.Artikelnummer != String.Empty)
            {
                if (sender.Equals(this.tbCharge))
                {
                    if (this.tbCharge.EditValue == null || (this.tbCharge.EditValue != null && this.tbCharge.EditValue.ToString() == String.Empty))
                    {
                        e.Cancel = true;
                    }
                }
                else if (sender.Equals(this.tbMenge1))
                {
                    if (this.tbMenge1.EditValue != null &&
                        (double)this.tbMenge1.EditValue > 0.0 &&
                        this.Menge2 > 0.0)
                    {
                        e.Cancel = true;
                        iError = 0;
                    }
                    if (this.tbMenge1.EditValue != null &&
                       (double)this.tbMenge1.EditValue == 0.0 &&
                        !this.tbMenge2.Visible)
                    {
                        e.Cancel = true;
                        iError = 1;
                    }
                }
                else if (sender.Equals(this.tbMenge2))
                {
                    if (this.tbMenge2.EditValue != null &&
                        (double)this.tbMenge2.EditValue > 0.0 &&
                        this.Menge1 > 0.0)
                    {
                        e.Cancel = true;
                        iError = 0;
                    }
                    //else if (this.tbMenge2.EditValue != null &&
                    //    (double)this.tbMenge2.EditValue == 0.0 &&
                    //    this.Menge1 == 0.0)
                    //{
                    //    e.Cancel = true;
                    //    iError = 1;
                    //}
                }
                else if (sender.Equals(this.tbLand))
                {
                    if (this.tbLand.EditValue == null || (this.tbLand.EditValue != null && this.tbLand.EditValue.ToString() == String.Empty))
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void tbInput_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            if (sender.Equals(this.tbInput))
                e.ErrorText = "Artikel nicht gefunden!";
            else if (sender.Equals(this.tbLand))
                e.ErrorText = "Das Land eingeben !";
            else if (sender.Equals(this.tbCharge))
                e.ErrorText = "Die Charge eingeben!";
            else if (sender.Equals(this.tbMenge1) && iError == 0)
            {
                e.ErrorText = "Menge 2 bereits vorhanden!";
            }
            else if (sender.Equals(this.tbMenge1) && iError == 1)
            {
                e.ErrorText = "Menge 1 nicht eingegeben!";
            }
            else if (sender.Equals(this.tbMenge2) && iError == 0)
            {
                e.ErrorText = "Menge 1 bereits vorhanden!";
            }
            else if (sender.Equals(this.tbMenge2) && iError == 1)
            {
                e.ErrorText = "Mindestens eine Menge muss eingegeben weerden!";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveDaten();
            InitFields();
            this.BeginInvoke(new Action(delegate
            {
                InvokeFocus();
            }));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool closeform = false;

            if (this.Artikelnummer != String.Empty)
            {
                closeform = MyXtraMessageBox.Show("Datensatz noch nicht gespeichert! Wollen Sie wirklich abbrechen?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;

                if (!closeform)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    this.BeginInvoke(new Action(delegate
                    {
                        InvokeFocus();
                    }));
                    return;
                }
            }


            using (LagerDlg ldlg = new LagerDlg())
            {
                if (ldlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Lagerfach = ldlg.Lagerort;
                    closeform = false;
                }
                else
                {
                    closeform = true;
                }
            }


            if (closeform)
                this.Close();
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                this.InitFields();
                this.BeginInvoke(new Action(delegate
                {
                    InvokeFocus();
                }));
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.InitFields();
            this.BeginInvoke(new Action(delegate
            {
                InvokeFocus();
            }));
        }

        #endregion events

        #region Layout 



        #endregion Layout



    }




}
