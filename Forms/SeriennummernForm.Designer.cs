namespace MiCLAS.MDE
{
    partial class SeriennummernForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.textEdit1.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
                this.btnAdd.Click -= new System.EventHandler(this.btnAdd_Click);
                this.btnRemove.Click -= new System.EventHandler(this.btnRemove_Click);
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriennummernForm));
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable1 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer1 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lcArtikel = new DevExpress.XtraEditors.LabelControl();
            this.lcSeriennummern = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.keyboardControlNum = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.keyboardControlNum);
            this.panelControl1.Controls.Add(this.btnRemove);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.lcSeriennummern);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lcArtikel);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.listBoxControl1);
            this.panelControl1.Size = new System.Drawing.Size(915, 561);
            this.panelControl1.Controls.SetChildIndex(this.listBoxControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.labelControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.lcArtikel, 0);
            this.panelControl1.Controls.SetChildIndex(this.labelControl3, 0);
            this.panelControl1.Controls.SetChildIndex(this.lcSeriennummern, 0);
            this.panelControl1.Controls.SetChildIndex(this.textEdit1, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnAdd, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnRemove, 0);
            this.panelControl1.Controls.SetChildIndex(this.keyboardControlNum, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnAbbruch, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnOK, 0);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(717, 447);
            this.btnOK.Size = new System.Drawing.Size(186, 102);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Speichern";
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbruch.Location = new System.Drawing.Point(819, 473);
            this.btnAbbruch.Size = new System.Drawing.Size(84, 76);
            this.btnAbbruch.Visible = false;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControl1.Location = new System.Drawing.Point(12, 134);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(798, 203);
            this.listBoxControl1.StyleController = this.styleController1;
            this.listBoxControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.StyleController = this.styleController1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Artikel Nr.:";
            // 
            // lcArtikel
            // 
            this.lcArtikel.Location = new System.Drawing.Point(169, 12);
            this.lcArtikel.Name = "lcArtikel";
            this.lcArtikel.Size = new System.Drawing.Size(30, 13);
            this.lcArtikel.StyleController = this.styleController1;
            this.lcArtikel.TabIndex = 0;
            this.lcArtikel.Text = "Artikel";
            // 
            // lcSeriennummern
            // 
            this.lcSeriennummern.Location = new System.Drawing.Point(169, 53);
            this.lcSeriennummern.Name = "lcSeriennummern";
            this.lcSeriennummern.Size = new System.Drawing.Size(22, 13);
            this.lcSeriennummern.StyleController = this.styleController1;
            this.lcSeriennummern.TabIndex = 1;
            this.lcSeriennummern.Text = "0 / 0";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.StyleController = this.styleController1;
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Serien Nr.:";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(12, 94);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 40;
            this.textEdit1.Size = new System.Drawing.Size(798, 20);
            this.textEdit1.StyleController = this.styleController1;
            this.textEdit1.TabIndex = 0;
            this.textEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(816, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRemove.Location = new System.Drawing.Point(816, 158);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 58);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // keyboardControlNum
            // 
            this.keyboardControlNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            virtualKeyboardColorTable1.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable1.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable1.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable1.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable1.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable1.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable1.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable1.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable1.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable1.TopBarTextColor = System.Drawing.Color.White;
            this.keyboardControlNum.ColorTable = virtualKeyboardColorTable1;
            this.keyboardControlNum.IsTopBarVisible = false;
            this.keyboardControlNum.Location = new System.Drawing.Point(12, 343);
            this.keyboardControlNum.Name = "keyboardControlNum";
            flatStyleRenderer1.ColorTable = virtualKeyboardColorTable1;
            flatStyleRenderer1.ForceAntiAlias = false;
            this.keyboardControlNum.Renderer = flatStyleRenderer1;
            this.keyboardControlNum.Size = new System.Drawing.Size(699, 206);
            this.keyboardControlNum.TabIndex = 16;
            this.keyboardControlNum.TabStop = false;
            this.keyboardControlNum.Text = "keyboardControl1";
            // 
            // SeriennummernForm
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SeriennummernForm";
            this.Text = "Seriennummern erfassen";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lcArtikel;
        private DevExpress.XtraEditors.LabelControl lcSeriennummern;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl keyboardControlNum;
    }
}