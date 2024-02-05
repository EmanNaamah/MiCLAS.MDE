using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCLAS.MDE.Base
{
    public class InputData
    {
        public string ArtBezeichnungInput { get; set; }
        public string Menge1TextInput { get; set; }
        public string Menge2TextInput { get; set; }
        public string Abmassfeld1TextInput { get; set; }
        public string Abmassfeld2TextInput { get; set; }
        public string Abmassfeld3TextInput { get; set; }
        public string Abmassfeld4TextInput { get; set; }
        public bool _SeriennummerInput { get; set; } = false;
        public bool bCharge { get; set; } = false;
        public bool bLand { get; set; } = false;
        public bool ResultInput { get; set; } = false;
        public string ArtikelnummerInput { get; set; }
        public string HerstelldatumInput { get; private set; }
        public string VerfallsdatumInput { get; private set; }
        public int HerstelldatumStatus { get; set; }
        public int VerfallsdatumStatus { get; set; }
        public string UrsprungslandInput { get; private set; }
        public string Seriennummer { get; private set; }
        public string ChargeInput { get; private set; }
        public int Menge1 { get; private set; }

        public bool Istvalid(string input, string _DefaultInventurFilter)
        {
            if (input != String.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string strSQL = "SELECT * FROM MDEArtikel WHERE " + String.Format(_DefaultInventurFilter, input);

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        using (OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                ArtikelnummerInput = reader.GetStringValue("Artikelnummer");
                                ArtBezeichnungInput = reader.GetStringValue("Bezeichnung1");
                                this.Menge1TextInput = reader.GetStringValue("Mengeneinheit1");
                                this.Menge2TextInput = reader.GetStringValue("Mengeneinheit2");
                                this.Abmassfeld1TextInput = reader.GetStringValue("Abmassfeld1");
                                this.Abmassfeld2TextInput = reader.GetStringValue("Abmassfeld2");
                                this.Abmassfeld3TextInput = reader.GetStringValue("Abmassfeld3");
                                this.Abmassfeld4TextInput = reader.GetStringValue("Abmassfeld4");
                                this._SeriennummerInput = reader.GetBoolValue("Seriennummernpflichtig");
                                bCharge = reader.GetBoolValue("Chargenpflichtig");
                                bLand = reader.GetBoolValue("Ursprungslandpflichtig");
                                HerstelldatumStatus = reader.GetIntValue("Hestelldatum");
                                VerfallsdatumStatus = reader.GetIntValue("Verfallsdatum");
                                ResultInput = true;
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
            }

            return ResultInput;
        }
        public bool isGs1(string gs1)
        {
            try
            {
                List<String> GS1ToList = gs1.Replace(@"".ToString(), ",").Split(',').ToList();
                List<String> ResultGs1List = new List<string>();

                for (int i = 0; i < GS1ToList.Count; i++)
                {

                    Dictionary<GS1Parser.AII, string> parsedstring = GS1Parser.Parse(GS1ToList[i]);

                    ResultGs1List.Add(string.Join(", ", parsedstring.Select(m => m.Key + "," + m.Value)));

                }
                if (ResultGs1List.Count > 0)
                {
                    if (ResultGs1List.FirstOrDefault(x => x.Contains("91")) != null)//change search filter he find all with this number connt use ble.10 artikelnr
                        ArtikelnummerInput = ResultGs1List.FirstOrDefault(x => x.Contains("91")).ToString().Split(new char[] { ',' }, 2)[1];
                    if (ResultGs1List.FirstOrDefault(x => x.Contains("10")) != null)
                        ChargeInput = ResultGs1List.FirstOrDefault(x => x.Contains("10")).ToString().Split(new char[] { ',' }, 2)[1];

                    if (ResultGs1List.FirstOrDefault(x => x.Contains("21")) != null)
                    {
                        Seriennummer = ResultGs1List.FirstOrDefault(x => x.Contains("21")).ToString().Split(new char[] { ',' }, 2)[1];
                    }
                    if (ResultGs1List.FirstOrDefault(x => x.Contains("422")) != null)
                    {
                        UrsprungslandInput = ResultGs1List.FirstOrDefault(x => x.Contains("422")).ToString().Split(new char[] { ',' }, 2)[1];
                        UrsprungslandInput = UrsprungslandInput.Substring(0, 3);
                    }
                      
                    if (ResultGs1List.FirstOrDefault(x => x.Contains("ProducerDate_JJMMDD")) != null)
                    {
                        HerstelldatumInput = ResultGs1List.FirstOrDefault(x => x.Contains("ProducerDate_JJMMDD")).ToString().Split(new char[] { ',' }, 2)[1];

                        if (!string.IsNullOrEmpty(UrsprungslandInput))
                        {
                            var index = HerstelldatumInput.IndexOf("ProducerDate_JJMMDD");
                            HerstelldatumInput = HerstelldatumInput.Substring(index + 21);
                        }

                        HerstelldatumInput = HerstelldatumInput.Substring(0, 6);
                        DateTime dt = DateTime.ParseExact(HerstelldatumInput, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                        string outp = dt.ToString("dd.MM.yyyy ");
                        HerstelldatumInput = outp;
                    }

                    if (ResultGs1List.FirstOrDefault(x => x.Contains("ExpiryDate_JJMMDD")) != null)
                    {
                        VerfallsdatumInput = ResultGs1List.FirstOrDefault(x => x.Contains("ExpiryDate_JJMMDD")).ToString().Split(new char[] { ',' }, 2)[1];
                        var index = VerfallsdatumInput.IndexOf("ExpiryDate_JJMMDD");
                        VerfallsdatumInput = VerfallsdatumInput.Substring(index+19);
                        VerfallsdatumInput = VerfallsdatumInput.Substring(0, 6);
                        DateTime dt = DateTime.ParseExact(VerfallsdatumInput, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                        string outp = dt.ToString("dd.MM.yyyy ");
                        VerfallsdatumInput = outp;
                    }


                    return (!string.IsNullOrEmpty(ArtikelnummerInput));
                }
                else
                    return false;
            }
            catch
            {
                XtraMessageBox.Show("Gs1 is not correct");
                return false;
            }



        }
    }
}
