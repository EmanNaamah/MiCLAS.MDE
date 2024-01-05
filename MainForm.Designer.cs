namespace MiCLAS.MDE
{
    partial class MainForm
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
                this.sbErfassungNeu.Click -= new System.EventHandler(this.sbErfassungNeu_Click);
                this.sbErfassungWeiter.Click -= new System.EventHandler(this.sbErfassungWeiter_Click);
                this.sbErfassungExport.Click -= new System.EventHandler(this.sbErfassungExport_Click);
                this.sbArtikelImport.Click -= new System.EventHandler(this.sbArtikelImport_Click);
                this.sbEnde.Click -= new System.EventHandler(this.sbEnde_Click);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.sbErfassungNeu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbEnde = new DevExpress.XtraEditors.SimpleButton();
            this.sbArtikelImport = new DevExpress.XtraEditors.SimpleButton();
            this.sbErfassungExport = new DevExpress.XtraEditors.SimpleButton();
            this.sbErfassungWeiter = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // sbErfassungNeu
            // 
            this.sbErfassungNeu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbErfassungNeu.Appearance.Options.UseTextOptions = true;
            this.sbErfassungNeu.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.sbErfassungNeu.Location = new System.Drawing.Point(20, 20);
            this.sbErfassungNeu.Name = "sbErfassungNeu";
            this.sbErfassungNeu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sbErfassungNeu.Size = new System.Drawing.Size(262, 101);
            this.sbErfassungNeu.StyleController = this.layoutControl1;
            this.sbErfassungNeu.TabIndex = 0;
            this.sbErfassungNeu.Text = "Neue Erfassung starten";
            this.sbErfassungNeu.Click += new System.EventHandler(this.sbErfassungNeu_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbEnde);
            this.layoutControl1.Controls.Add(this.sbArtikelImport);
            this.layoutControl1.Controls.Add(this.sbErfassungExport);
            this.layoutControl1.Controls.Add(this.sbErfassungWeiter);
            this.layoutControl1.Controls.Add(this.sbErfassungNeu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1239, 399, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(584, 262);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbEnde
            // 
            this.sbEnde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbEnde.Appearance.Options.UseTextOptions = true;
            this.sbEnde.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.sbEnde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbEnde.Location = new System.Drawing.Point(302, 181);
            this.sbEnde.Name = "sbEnde";
            this.sbEnde.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sbEnde.Size = new System.Drawing.Size(262, 61);
            this.sbEnde.StyleController = this.layoutControl1;
            this.sbEnde.TabIndex = 3;
            this.sbEnde.Text = "Erfassung beenden";
            this.sbEnde.Click += new System.EventHandler(this.sbEnde_Click);
            // 
            // sbArtikelImport
            // 
            this.sbArtikelImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbArtikelImport.Appearance.Options.UseTextOptions = true;
            this.sbArtikelImport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.sbArtikelImport.Location = new System.Drawing.Point(302, 101);
            this.sbArtikelImport.Name = "sbArtikelImport";
            this.sbArtikelImport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sbArtikelImport.Size = new System.Drawing.Size(262, 60);
            this.sbArtikelImport.StyleController = this.layoutControl1;
            this.sbArtikelImport.TabIndex = 4;
            this.sbArtikelImport.Text = "Artikel importieren";
            this.sbArtikelImport.Click += new System.EventHandler(this.sbArtikelImport_Click);
            // 
            // sbErfassungExport
            // 
            this.sbErfassungExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbErfassungExport.Appearance.Options.UseTextOptions = true;
            this.sbErfassungExport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.sbErfassungExport.Location = new System.Drawing.Point(302, 20);
            this.sbErfassungExport.Name = "sbErfassungExport";
            this.sbErfassungExport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sbErfassungExport.Size = new System.Drawing.Size(262, 61);
            this.sbErfassungExport.StyleController = this.layoutControl1;
            this.sbErfassungExport.TabIndex = 2;
            this.sbErfassungExport.Text = "Erfassung exportieren";
            this.sbErfassungExport.Click += new System.EventHandler(this.sbErfassungExport_Click);
            // 
            // sbErfassungWeiter
            // 
            this.sbErfassungWeiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbErfassungWeiter.Appearance.Options.UseTextOptions = true;
            this.sbErfassungWeiter.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.sbErfassungWeiter.Location = new System.Drawing.Point(20, 141);
            this.sbErfassungWeiter.Name = "sbErfassungWeiter";
            this.sbErfassungWeiter.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sbErfassungWeiter.Size = new System.Drawing.Size(262, 101);
            this.sbErfassungWeiter.StyleController = this.layoutControl1;
            this.sbErfassungWeiter.TabIndex = 1;
            this.sbErfassungWeiter.Text = "Erfassung fortführen";
            this.sbErfassungWeiter.Click += new System.EventHandler(this.sbErfassungWeiter_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(584, 262);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(282, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(282, 242);
            this.layoutControlGroup1.Text = "Optionen";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbErfassungExport;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(282, 81);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbArtikelImport;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(282, 80);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbEnde;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 161);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(106, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(282, 81);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(282, 242);
            this.layoutControlGroup2.Text = "Inventur";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbErfassungNeu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(127, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(282, 121);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbErfassungWeiter;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(114, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(282, 121);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbEnde;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiCLAS.Inventur";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton sbErfassungNeu;
        private DevExpress.XtraEditors.SimpleButton sbErfassungWeiter;
        private DevExpress.XtraEditors.SimpleButton sbErfassungExport;
        private DevExpress.XtraEditors.SimpleButton sbArtikelImport;
        private DevExpress.XtraEditors.SimpleButton sbEnde;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}