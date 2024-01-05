using DevComponents.DotNetBar.Keyboard;
using DevExpress.XtraEditors;
using MiCLAS.MDE.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCLAS.MDE
{
    public partial class BenutzerDlg : BaseDialog
    {
        int _BenuzterNummer = 0;

        public int BenuzterNummer
        {
            get { return _BenuzterNummer; }
            set { _BenuzterNummer = value; }
        }

        public BenutzerDlg()
        {
            InitializeComponent();

            this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateNumericKeyboard();
            this.keyboardControlNum.Invalidate();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            int iValue = -1;

            bool result = false;

            if (this.textEdit1.EditValue != null && this.textEdit1.EditValue.ToString() != String.Empty)
            {
                iValue = Convert.ToInt32(this.textEdit1.EditValue);

                using (OleDbConnection conn = new OleDbConnection(PublicAttributes.DataConnection.ConnectionString))
                {
                    conn.Open();

                    try
                    {
                        string strSQL = String.Format("SELECT COUNT(*) FROM MDEBenutzer WHERE Benutzernummer = {0}", iValue);

                        using (OleDbCommand cmd = new OleDbCommand(strSQL, conn))
                        {
                            object obj = cmd.ExecuteScalar();

                            if (obj != null)
                            {
                                result = Convert.ToInt32(obj) > 0;
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

                if (!result)
                {
                    MyXtraMessageBox.Show("Benutzer nicht vorhanden!");
                    DialogResult = System.Windows.Forms.DialogResult.None;
                    this.textEdit1.Focus();
                    return;
                }
                else
                {
                    this.BenuzterNummer = iValue;
                }
            }

            base.btnOK_Click(sender, e);
        }

      
    }
}
