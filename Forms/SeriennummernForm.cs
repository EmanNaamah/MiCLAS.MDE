using MiCLAS.MDE.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCLAS.MDE
{
    public partial class SeriennummernForm : BaseDialog
    {
        List<string> _Seriennummern = null;

        public List<string> Seriennummern
        {
            get { return _Seriennummern; }
            set { _Seriennummern = value; }
        }

        int _Total = 0;

        public int Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        string _Artikelnummer = String.Empty;

        public string Artikelnummer
        {
            get { return _Artikelnummer; }
            set { _Artikelnummer = value; }
        }

        public SeriennummernForm()
        {
            InitializeComponent();

            this.keyboardControlNum.Keyboard = KeyboardTemplate.CreateDefaultKeyboard();
            this.keyboardControlNum.Invalidate();

            this._Seriennummern = new List<string>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.lcArtikel.Text = Artikelnummer;

            this.UpdateText();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                AddItem();
            }
        }

        private void AddItem()
        {


            if (this.textEdit1.EditValue != null && this.textEdit1.EditValue.ToString() != String.Empty)
            {
                if (!this.listBoxControl1.Items.Contains(this.textEdit1.EditValue))
                {
                    this.listBoxControl1.Items.Add(this.textEdit1.EditValue);
                    UpdateText();
                    this.textEdit1.EditValue = String.Empty;
                }
                else
                {
                    MyXtraMessageBox.Show("Die Serien-Nr. wurde schon erfasst!");
                }
            }
        }

        private void RemoveItem()
        {
            if (this.listBoxControl1.SelectedItem != null)
            {
                this.listBoxControl1.Items.Remove(this.listBoxControl1.SelectedItem);
                UpdateText();
            }
        }

        void UpdateText()
        {
            this.lcSeriennummern.Text = String.Format("{0} / {1}", this.listBoxControl1.Items.Count, this.Total);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            bool result = true;

            if (this.listBoxControl1.Items.Count < this.Total)
            {
                result = MyXtraMessageBox.Show("Die Anzahl der Serien-Nr ist kleiner als die erwartete.\nWeitere eingeben?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No;
            }
            else if (this.listBoxControl1.Items.Count > this.Total)
            {
                result = MyXtraMessageBox.Show("Die Anzahl der Serien-Nr ist größer als die erwartete.\nWeiter?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;
            }

            if (result)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                foreach (object obj in this.listBoxControl1.Items)
                {
                    this._Seriennummern.Add(obj.ToString());
                }

                this.Close();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                this.textEdit1.Focus();
            }
        }
    }
}
