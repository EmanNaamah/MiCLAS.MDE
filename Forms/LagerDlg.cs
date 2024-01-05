using DevComponents.DotNetBar.Keyboard;
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
    public partial class LagerDlg : BaseDialog
    {
        string _Lagerort = String.Empty;

        public string Lagerort
        {
            get { return _Lagerort; }
            set { _Lagerort = value; }
        }

        public LagerDlg()
        {
            InitializeComponent();

            this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateAZ19KeyboardEx();
            this.keyboardControlNum.Invalidate();
        }    
              

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = !this.ValidateChildren();

                if (!e.Cancel)
                {
                    this.Lagerort = this.textEdit1.EditValue.ToString().ToUpper();
                }
                else
                {
                    this.textEdit1.Focus();
                }
            }
        }

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textEdit1.EditValue != null)
            {
                string strValue = this.textEdit1.EditValue.ToString();                

                string[] arrSatz = strValue.Split('#');
                if (arrSatz.Length < 2)
                    arrSatz = strValue.Split('.');

                if (arrSatz.Length >= 2 &&
                    arrSatz[0].Trim() != String.Empty &&
                    arrSatz[1].Trim() != String.Empty)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }      
        }

        private void textEdit1_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Lagerplatz nicht korrekt!";
        }

    

        
    }
}
