namespace MiCLAS.MDE
{
    partial class BaseDialog
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
                this.btnOK.Click -= new System.EventHandler(this.btnOK_Click);
                this.btnAbbruch.Click -= new System.EventHandler(this.btnAbbruch_Click);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDialog));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbbruch = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(690, 494);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnOK.Size = new System.Drawing.Size(238, 155);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbruch.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btnAbbruch.Appearance.Options.UseFont = true;
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(934, 494);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAbbruch.Size = new System.Drawing.Size(238, 155);
            this.btnAbbruch.TabIndex = 3;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // BaseDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbruch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "BaseDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Base Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton btnOK;
        protected DevExpress.XtraEditors.SimpleButton btnAbbruch;
    }
}