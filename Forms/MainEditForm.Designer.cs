namespace MiCLAS.MDE
{
    partial class MainEditForm
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
                this.btnAbbruch.Click -= new System.EventHandler(this.simpleButton2_Click);
                this.btnSpeichern.Click -= new System.EventHandler(this.simpleButton1_Click);
                this.tbAb4.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbAb3.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbAb2.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbAb1.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbMenge2.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbMenge1.InvalidValue -= new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
                this.tbMenge1.Validating -= new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
                this.tbLand.InvalidValue -= new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
                this.tbLand.Validating -= new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
                this.tbMenge1.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbCharge.InvalidValue -= new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
                this.tbCharge.Validating -= new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
                this.tbCharge.Leave -= new System.EventHandler(this.tbField_Validated);
                this.tbInput.InvalidValue -= new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
                this.tbInput.Validating -= new System.ComponentModel.CancelEventHandler(this.tbInput_Validating);
                this.btnResetScan.Click -= simpleButton1_Click_1;
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
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable1 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer1 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditForm));
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.lcMengeGezaeht2 = new DevExpress.XtraEditors.LabelControl();
            this.lbBenuzter = new DevExpress.XtraEditors.LabelControl();
            this.lcMengeGezaeht = new DevExpress.XtraEditors.LabelControl();
            this.btnResetScan = new DevExpress.XtraEditors.SimpleButton();
            this.lcBezeichnung = new DevExpress.XtraEditors.LabelControl();
            this.btnAbbruch = new DevExpress.XtraEditors.SimpleButton();
            this.btnSpeichern = new DevExpress.XtraEditors.SimpleButton();
            this.lcArtikelnummer = new DevExpress.XtraEditors.LabelControl();
            this.lcLager = new DevExpress.XtraEditors.LabelControl();
            this.tbHerstelldatum = new DevExpress.XtraEditors.DateEdit();
            this.tbVerfallsdatum = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLcArtikelnummer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLcLager = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLbBenuzter = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLcBezeichnung = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLcMengeGezaeht = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLcMengeGezaeht2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnSpeichern = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnAbbruch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnResetScan = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciTbHerstelldatum = new DevExpress.XtraLayout.LayoutControlItem();
            this.sllMenge1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciTbVerfallsdatum = new DevExpress.XtraLayout.LayoutControlItem();
            this.sllMenge2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.toolTipController11 = new DevExpress.Utils.ToolTipController(this.components);
            this.tbSeriennummer = new MiCLAS.MDE.CustomTextEdit();
            this.tbLand = new MiCLAS.MDE.CustomTextEdit();
            this.keyboardControlNum = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.tbAb4 = new MiCLAS.MDE.CustomTextEdit();
            this.tbAb3 = new MiCLAS.MDE.CustomTextEdit();
            this.tbAb2 = new MiCLAS.MDE.CustomTextEdit();
            this.tbAb1 = new MiCLAS.MDE.CustomTextEdit();
            this.tbMenge2 = new MiCLAS.MDE.CustomTextEdit();
            this.tbMenge1 = new MiCLAS.MDE.CustomTextEdit();
            this.tbCharge = new MiCLAS.MDE.CustomTextEdit();
            this.tbInput = new MiCLAS.MDE.CustomTextEdit();
            this.lciTbInput = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbCharge = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKeyboardControlNum = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLand = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbAb1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbAb2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbAb3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbAb4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbMenge1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTbMenge2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciTbSeriennummer = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHerstelldatum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHerstelldatum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerfallsdatum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerfallsdatum.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcArtikelnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcLager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLbBenuzter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcBezeichnung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcMengeGezaeht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcMengeGezaeht2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSpeichern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnAbbruch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnResetScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbHerstelldatum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sllMenge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbVerfallsdatum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sllMenge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSeriennummer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenge2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenge1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyboardControlNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbMenge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbMenge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTbSeriennummer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.tbSeriennummer);
            this.mainLayoutControl.Controls.Add(this.tbLand);
            this.mainLayoutControl.Controls.Add(this.lcMengeGezaeht2);
            this.mainLayoutControl.Controls.Add(this.lbBenuzter);
            this.mainLayoutControl.Controls.Add(this.lcMengeGezaeht);
            this.mainLayoutControl.Controls.Add(this.btnResetScan);
            this.mainLayoutControl.Controls.Add(this.lcBezeichnung);
            this.mainLayoutControl.Controls.Add(this.btnAbbruch);
            this.mainLayoutControl.Controls.Add(this.btnSpeichern);
            this.mainLayoutControl.Controls.Add(this.keyboardControlNum);
            this.mainLayoutControl.Controls.Add(this.tbAb4);
            this.mainLayoutControl.Controls.Add(this.tbAb3);
            this.mainLayoutControl.Controls.Add(this.tbAb2);
            this.mainLayoutControl.Controls.Add(this.tbAb1);
            this.mainLayoutControl.Controls.Add(this.tbMenge2);
            this.mainLayoutControl.Controls.Add(this.tbMenge1);
            this.mainLayoutControl.Controls.Add(this.tbCharge);
            this.mainLayoutControl.Controls.Add(this.tbInput);
            this.mainLayoutControl.Controls.Add(this.lcArtikelnummer);
            this.mainLayoutControl.Controls.Add(this.lcLager);
            this.mainLayoutControl.Controls.Add(this.tbHerstelldatum);
            this.mainLayoutControl.Controls.Add(this.tbVerfallsdatum);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(538, 254, 1382, 778);
            this.mainLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.mainLayoutControl.Root = this.layoutControlGroup1;
            this.mainLayoutControl.Size = new System.Drawing.Size(885, 426);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.IconSize = DevExpress.Utils.ToolTipIconSize.Large;
            // 
            // lcMengeGezaeht2
            // 
            this.lcMengeGezaeht2.Appearance.Image = global::MiCLAS.MDE.Properties.Resources.Apply_32x32;
            this.lcMengeGezaeht2.Appearance.Options.UseImage = true;
            this.lcMengeGezaeht2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lcMengeGezaeht2.Location = new System.Drawing.Point(168, 80);
            this.lcMengeGezaeht2.Name = "lcMengeGezaeht2";
            this.lcMengeGezaeht2.Size = new System.Drawing.Size(65, 36);
            this.lcMengeGezaeht2.StyleController = this.mainLayoutControl;
            this.lcMengeGezaeht2.TabIndex = 19;
            this.lcMengeGezaeht2.Text = "0,000";
            // 
            // lbBenuzter
            // 
            this.lbBenuzter.Location = new System.Drawing.Point(99, 12);
            this.lbBenuzter.Name = "lbBenuzter";
            this.lbBenuzter.Size = new System.Drawing.Size(43, 13);
            this.lbBenuzter.StyleController = this.mainLayoutControl;
            this.lbBenuzter.TabIndex = 18;
            this.lbBenuzter.Text = "Benutzer";
            // 
            // lcMengeGezaeht
            // 
            this.lcMengeGezaeht.Appearance.Image = global::MiCLAS.MDE.Properties.Resources.Apply_32x32;
            this.lcMengeGezaeht.Appearance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lcMengeGezaeht.Appearance.Options.UseImage = true;
            this.lcMengeGezaeht.Appearance.Options.UseImageAlign = true;
            this.lcMengeGezaeht.Appearance.Options.UseTextOptions = true;
            this.lcMengeGezaeht.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcMengeGezaeht.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lcMengeGezaeht.Location = new System.Drawing.Point(99, 80);
            this.lcMengeGezaeht.Name = "lcMengeGezaeht";
            this.lcMengeGezaeht.Size = new System.Drawing.Size(65, 36);
            this.lcMengeGezaeht.StyleController = this.mainLayoutControl;
            this.lcMengeGezaeht.TabIndex = 17;
            this.lcMengeGezaeht.Text = "0,000";
            // 
            // btnResetScan
            // 
            this.btnResetScan.Appearance.Options.UseTextOptions = true;
            this.btnResetScan.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnResetScan.CausesValidation = false;
            this.btnResetScan.Location = new System.Drawing.Point(600, 236);
            this.btnResetScan.Name = "btnResetScan";
            this.btnResetScan.Size = new System.Drawing.Size(273, 178);
            this.btnResetScan.StyleController = this.mainLayoutControl;
            this.btnResetScan.TabIndex = 16;
            this.btnResetScan.Text = "Zurück zum Scan";
            this.btnResetScan.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // lcBezeichnung
            // 
            this.lcBezeichnung.Location = new System.Drawing.Point(99, 63);
            this.lcBezeichnung.Name = "lcBezeichnung";
            this.lcBezeichnung.Size = new System.Drawing.Size(497, 13);
            this.lcBezeichnung.StyleController = this.mainLayoutControl;
            this.lcBezeichnung.TabIndex = 15;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Appearance.Options.UseTextOptions = true;
            this.btnAbbruch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAbbruch.AutoWidthInLayoutControl = true;
            this.btnAbbruch.CausesValidation = false;
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(600, 124);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(273, 108);
            this.btnAbbruch.StyleController = this.mainLayoutControl;
            this.btnAbbruch.TabIndex = 15;
            this.btnAbbruch.Text = "Beenden / Lager wechseln";
            this.btnAbbruch.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.AutoWidthInLayoutControl = true;
            this.btnSpeichern.Location = new System.Drawing.Point(600, 12);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(273, 108);
            this.btnSpeichern.StyleController = this.mainLayoutControl;
            this.btnSpeichern.TabIndex = 14;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lcArtikelnummer
            // 
            this.lcArtikelnummer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lcArtikelnummer.Location = new System.Drawing.Point(99, 46);
            this.lcArtikelnummer.Name = "lcArtikelnummer";
            this.lcArtikelnummer.Size = new System.Drawing.Size(497, 13);
            this.lcArtikelnummer.StyleController = this.mainLayoutControl;
            this.lcArtikelnummer.TabIndex = 1;
            this.lcArtikelnummer.Text = "Bezeichnung";
            // 
            // lcLager
            // 
            this.lcLager.Location = new System.Drawing.Point(99, 29);
            this.lcLager.Name = "lcLager";
            this.lcLager.Size = new System.Drawing.Size(27, 13);
            this.lcLager.StyleController = this.mainLayoutControl;
            this.lcLager.TabIndex = 0;
            this.lcLager.Text = "Lager";
            // 
            // tbHerstelldatum
            // 
            this.tbHerstelldatum.EditValue = null;
            this.tbHerstelldatum.Location = new System.Drawing.Point(99, 192);
            this.tbHerstelldatum.Name = "tbHerstelldatum";
            this.tbHerstelldatum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbHerstelldatum.Properties.CalendarTimeProperties.AllowMouseWheel = false;
            this.tbHerstelldatum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbHerstelldatum.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "d");
            this.tbHerstelldatum.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.tbHerstelldatum.Properties.NullDate = "";
            this.tbHerstelldatum.Properties.UseMaskAsDisplayFormat = true;
            this.tbHerstelldatum.Size = new System.Drawing.Size(191, 20);
            this.tbHerstelldatum.StyleController = this.mainLayoutControl;
            this.tbHerstelldatum.TabIndex = 5;
            this.tbHerstelldatum.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbHerstelldatum.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbHerstelldatum.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // tbVerfallsdatum
            // 
            this.tbVerfallsdatum.EditValue = null;
            this.tbVerfallsdatum.Location = new System.Drawing.Point(99, 216);
            this.tbVerfallsdatum.Name = "tbVerfallsdatum";
            this.tbVerfallsdatum.Properties.AllowMouseWheel = false;
            this.tbVerfallsdatum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbVerfallsdatum.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbVerfallsdatum.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "d");
            this.tbVerfallsdatum.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.tbVerfallsdatum.Properties.NullDate = "";
            this.tbVerfallsdatum.Properties.UseMaskAsDisplayFormat = true;
            this.tbVerfallsdatum.Size = new System.Drawing.Size(191, 20);
            this.tbVerfallsdatum.StyleController = this.mainLayoutControl;
            this.tbVerfallsdatum.TabIndex = 6;
            this.tbVerfallsdatum.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbVerfallsdatum.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbVerfallsdatum.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLcArtikelnummer,
            this.lciLcLager,
            this.lciTbInput,
            this.lciTbCharge,
            this.lciLbBenuzter,
            this.layoutControlGroup2,
            this.lciLcBezeichnung,
            this.lciLcMengeGezaeht,
            this.lciLcMengeGezaeht2,
            this.lciLand,
            this.lciTbAb1,
            this.lciTbAb2,
            this.lciTbAb3,
            this.lciTbAb4,
            this.lciBtnSpeichern,
            this.lciBtnAbbruch,
            this.lciBtnResetScan,
            this.emptySpaceItem4,
            this.lciTbMenge1,
            this.lciTbHerstelldatum,
            this.sllMenge1,
            this.lciTbMenge2,
            this.lciTbVerfallsdatum,
            this.sllMenge2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem6,
            this.emptySpaceItem5,
            this.LciTbSeriennummer,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(885, 426);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciLcArtikelnummer
            // 
            this.lciLcArtikelnummer.Control = this.lcArtikelnummer;
            this.lciLcArtikelnummer.CustomizationFormText = "Artikel Nr.:";
            this.lciLcArtikelnummer.Location = new System.Drawing.Point(0, 34);
            this.lciLcArtikelnummer.Name = "lciLcArtikelnummer";
            this.lciLcArtikelnummer.Size = new System.Drawing.Size(588, 17);
            this.lciLcArtikelnummer.Text = "Artikel Nr.:";
            this.lciLcArtikelnummer.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciLcLager
            // 
            this.lciLcLager.Control = this.lcLager;
            this.lciLcLager.CustomizationFormText = "Lagerfach:";
            this.lciLcLager.Location = new System.Drawing.Point(0, 17);
            this.lciLcLager.Name = "lciLcLager";
            this.lciLcLager.Size = new System.Drawing.Size(588, 17);
            this.lciLcLager.Text = "Lagerfach:";
            this.lciLcLager.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciLbBenuzter
            // 
            this.lciLbBenuzter.Control = this.lbBenuzter;
            this.lciLbBenuzter.CustomizationFormText = "Benutzer:";
            this.lciLbBenuzter.Location = new System.Drawing.Point(0, 0);
            this.lciLbBenuzter.Name = "lciLbBenuzter";
            this.lciLbBenuzter.Size = new System.Drawing.Size(588, 17);
            this.lciLbBenuzter.Text = "Benutzer:";
            this.lciLbBenuzter.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciKeyboardControlNum});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 276);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup2.Size = new System.Drawing.Size(588, 130);
            // 
            // lciLcBezeichnung
            // 
            this.lciLcBezeichnung.Control = this.lcBezeichnung;
            this.lciLcBezeichnung.CustomizationFormText = "Bezeichnung:";
            this.lciLcBezeichnung.Location = new System.Drawing.Point(0, 51);
            this.lciLcBezeichnung.Name = "lciLcBezeichnung";
            this.lciLcBezeichnung.Size = new System.Drawing.Size(588, 17);
            this.lciLcBezeichnung.Text = "Bezeichnung:";
            this.lciLcBezeichnung.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciLcMengeGezaeht
            // 
            this.lciLcMengeGezaeht.Control = this.lcMengeGezaeht;
            this.lciLcMengeGezaeht.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lciLcMengeGezaeht.CustomizationFormText = "Bereits gezählt:";
            this.lciLcMengeGezaeht.Location = new System.Drawing.Point(0, 68);
            this.lciLcMengeGezaeht.Name = "lciLcMengeGezaeht";
            this.lciLcMengeGezaeht.Size = new System.Drawing.Size(156, 40);
            this.lciLcMengeGezaeht.Text = "Bereits gezählt:";
            this.lciLcMengeGezaeht.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciLcMengeGezaeht2
            // 
            this.lciLcMengeGezaeht2.Control = this.lcMengeGezaeht2;
            this.lciLcMengeGezaeht2.CustomizationFormText = "layoutControlItem8";
            this.lciLcMengeGezaeht2.Location = new System.Drawing.Point(156, 68);
            this.lciLcMengeGezaeht2.Name = "lciLcMengeGezaeht2";
            this.lciLcMengeGezaeht2.Size = new System.Drawing.Size(432, 40);
            this.lciLcMengeGezaeht2.TextSize = new System.Drawing.Size(0, 0);
            this.lciLcMengeGezaeht2.TextVisible = false;
            // 
            // lciBtnSpeichern
            // 
            this.lciBtnSpeichern.Control = this.btnSpeichern;
            this.lciBtnSpeichern.CustomizationFormText = "layoutControlItem12";
            this.lciBtnSpeichern.Location = new System.Drawing.Point(588, 0);
            this.lciBtnSpeichern.MinSize = new System.Drawing.Size(60, 26);
            this.lciBtnSpeichern.Name = "lciBtnSpeichern";
            this.lciBtnSpeichern.Size = new System.Drawing.Size(277, 112);
            this.lciBtnSpeichern.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnSpeichern.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnSpeichern.TextVisible = false;
            // 
            // lciBtnAbbruch
            // 
            this.lciBtnAbbruch.Control = this.btnAbbruch;
            this.lciBtnAbbruch.CustomizationFormText = "layoutControlItem13";
            this.lciBtnAbbruch.Location = new System.Drawing.Point(588, 112);
            this.lciBtnAbbruch.MinSize = new System.Drawing.Size(139, 26);
            this.lciBtnAbbruch.Name = "lciBtnAbbruch";
            this.lciBtnAbbruch.Size = new System.Drawing.Size(277, 112);
            this.lciBtnAbbruch.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnAbbruch.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnAbbruch.TextVisible = false;
            // 
            // lciBtnResetScan
            // 
            this.lciBtnResetScan.Control = this.btnResetScan;
            this.lciBtnResetScan.CustomizationFormText = "layoutControlItem5";
            this.lciBtnResetScan.Location = new System.Drawing.Point(588, 224);
            this.lciBtnResetScan.MinSize = new System.Drawing.Size(93, 26);
            this.lciBtnResetScan.Name = "lciBtnResetScan";
            this.lciBtnResetScan.Size = new System.Drawing.Size(277, 182);
            this.lciBtnResetScan.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnResetScan.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnResetScan.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(141, 156);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(168, 24);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciTbHerstelldatum
            // 
            this.lciTbHerstelldatum.Control = this.tbHerstelldatum;
            this.lciTbHerstelldatum.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciTbHerstelldatum.CustomizationFormText = "Herstelldatum";
            this.lciTbHerstelldatum.Location = new System.Drawing.Point(0, 180);
            this.lciTbHerstelldatum.Name = "lciTbHerstelldatum";
            this.lciTbHerstelldatum.Size = new System.Drawing.Size(282, 24);
            this.lciTbHerstelldatum.Text = "Herstelldatum :";
            this.lciTbHerstelldatum.TextSize = new System.Drawing.Size(75, 13);
            // 
            // sllMenge1
            // 
            this.sllMenge1.AllowHotTrack = false;
            this.sllMenge1.CustomizationFormText = "Stck";
            this.sllMenge1.Location = new System.Drawing.Point(237, 228);
            this.sllMenge1.Name = "sllMenge1";
            this.sllMenge1.Size = new System.Drawing.Size(97, 24);
            this.sllMenge1.Text = "Stck";
            this.sllMenge1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbVerfallsdatum
            // 
            this.lciTbVerfallsdatum.Control = this.tbVerfallsdatum;
            this.lciTbVerfallsdatum.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciTbVerfallsdatum.CustomizationFormText = "Verfallsdatum :";
            this.lciTbVerfallsdatum.Location = new System.Drawing.Point(0, 204);
            this.lciTbVerfallsdatum.Name = "lciTbVerfallsdatum";
            this.lciTbVerfallsdatum.Size = new System.Drawing.Size(282, 24);
            this.lciTbVerfallsdatum.Text = "Verfallsdatum :";
            this.lciTbVerfallsdatum.TextSize = new System.Drawing.Size(75, 13);
            // 
            // sllMenge2
            // 
            this.sllMenge2.AllowHotTrack = false;
            this.sllMenge2.CustomizationFormText = "Stck";
            this.sllMenge2.Location = new System.Drawing.Point(237, 252);
            this.sllMenge2.Name = "sllMenge2";
            this.sllMenge2.Size = new System.Drawing.Size(97, 24);
            this.sllMenge2.Text = "Stck";
            this.sllMenge2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(282, 204);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(69, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(282, 180);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(69, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(334, 228);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(17, 24);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(334, 252);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(17, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(309, 156);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(42, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // toolTipController11
            // 
            this.toolTipController11.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController11.Appearance.Options.UseFont = true;
            this.toolTipController11.IconSize = DevExpress.Utils.ToolTipIconSize.Large;
            // 
            // tbSeriennummer
            // 
            this.tbSeriennummer.Location = new System.Drawing.Point(450, 168);
            this.tbSeriennummer.Name = "tbSeriennummer";
            this.tbSeriennummer.Size = new System.Drawing.Size(146, 20);
            this.tbSeriennummer.StyleController = this.mainLayoutControl;
            this.tbSeriennummer.TabIndex = 9;
            this.tbSeriennummer.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbSeriennummer.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbSeriennummer.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // tbLand
            // 
            this.tbLand.Location = new System.Drawing.Point(99, 168);
            this.tbLand.Name = "tbLand";
            this.tbLand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLand.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbLand.Properties.MaxLength = 3;
            this.tbLand.Size = new System.Drawing.Size(50, 20);
            this.tbLand.StyleController = this.mainLayoutControl;
            this.tbLand.TabIndex = 4;
            this.tbLand.ToolTipController = this.toolTipController1;
            this.tbLand.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbLand.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbLand.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // keyboardControlNum
            // 
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
            this.keyboardControlNum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.keyboardControlNum.IsTopBarVisible = false;
            this.keyboardControlNum.Location = new System.Drawing.Point(12, 288);
            this.keyboardControlNum.Name = "keyboardControlNum";
            flatStyleRenderer1.ColorTable = virtualKeyboardColorTable1;
            flatStyleRenderer1.ForceAntiAlias = false;
            this.keyboardControlNum.Renderer = flatStyleRenderer1;
            this.keyboardControlNum.Size = new System.Drawing.Size(584, 126);
            this.keyboardControlNum.TabIndex = 14;
            this.keyboardControlNum.TabStop = false;
            this.keyboardControlNum.Text = "keyboardControl1";
            // 
            // tbAb4
            // 
            this.tbAb4.Location = new System.Drawing.Point(450, 264);
            this.tbAb4.Name = "tbAb4";
            this.tbAb4.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAb4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbAb4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbAb4.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbAb4.Properties.MaskSettings.Set("mask", "N3");
            this.tbAb4.Properties.MaxLength = 12;
            this.tbAb4.Size = new System.Drawing.Size(146, 20);
            this.tbAb4.StyleController = this.mainLayoutControl;
            this.tbAb4.TabIndex = 13;
            this.tbAb4.ToolTipController = this.toolTipController1;
            this.tbAb4.Leave += new System.EventHandler(this.tbField_Validated);
            // 
            // tbAb3
            // 
            this.tbAb3.Location = new System.Drawing.Point(450, 240);
            this.tbAb3.Name = "tbAb3";
            this.tbAb3.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAb3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbAb3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbAb3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbAb3.Properties.MaskSettings.Set("mask", "N3");
            this.tbAb3.Properties.MaxLength = 12;
            this.tbAb3.Size = new System.Drawing.Size(146, 20);
            this.tbAb3.StyleController = this.mainLayoutControl;
            this.tbAb3.TabIndex = 12;
            this.tbAb3.ToolTipController = this.toolTipController1;
            this.tbAb3.Leave += new System.EventHandler(this.tbField_Validated);
            // 
            // tbAb2
            // 
            this.tbAb2.Location = new System.Drawing.Point(450, 216);
            this.tbAb2.Name = "tbAb2";
            this.tbAb2.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAb2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbAb2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbAb2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbAb2.Properties.MaskSettings.Set("mask", "N3");
            this.tbAb2.Properties.MaxLength = 12;
            this.tbAb2.Size = new System.Drawing.Size(146, 20);
            this.tbAb2.StyleController = this.mainLayoutControl;
            this.tbAb2.TabIndex = 11;
            this.tbAb2.ToolTipController = this.toolTipController1;
            this.tbAb2.Leave += new System.EventHandler(this.tbField_Validated);
            // 
            // tbAb1
            // 
            this.tbAb1.Location = new System.Drawing.Point(450, 192);
            this.tbAb1.Name = "tbAb1";
            this.tbAb1.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAb1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbAb1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbAb1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbAb1.Properties.MaskSettings.Set("mask", "N3");
            this.tbAb1.Properties.MaxLength = 12;
            this.tbAb1.Size = new System.Drawing.Size(146, 20);
            this.tbAb1.StyleController = this.mainLayoutControl;
            this.tbAb1.TabIndex = 10;
            this.tbAb1.ToolTipController = this.toolTipController1;
            this.tbAb1.Leave += new System.EventHandler(this.tbField_Validated);
            // 
            // tbMenge2
            // 
            this.tbMenge2.Location = new System.Drawing.Point(99, 264);
            this.tbMenge2.Name = "tbMenge2";
            this.tbMenge2.Properties.Appearance.Options.UseTextOptions = true;
            this.tbMenge2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbMenge2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbMenge2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbMenge2.Properties.MaskSettings.Set("mask", "N3");
            this.tbMenge2.Properties.MaxLength = 12;
            this.tbMenge2.Size = new System.Drawing.Size(146, 20);
            this.tbMenge2.StyleController = this.mainLayoutControl;
            this.tbMenge2.TabIndex = 8;
            this.tbMenge2.ToolTipController = this.toolTipController1;
            this.tbMenge2.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbMenge2.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbMenge2.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // tbMenge1
            // 
            this.tbMenge1.Location = new System.Drawing.Point(99, 240);
            this.tbMenge1.Name = "tbMenge1";
            this.tbMenge1.Properties.Appearance.Options.UseTextOptions = true;
            this.tbMenge1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbMenge1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbMenge1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbMenge1.Properties.MaskSettings.Set("mask", "N3");
            this.tbMenge1.Properties.MaxLength = 12;
            this.tbMenge1.Size = new System.Drawing.Size(146, 20);
            this.tbMenge1.StyleController = this.mainLayoutControl;
            this.tbMenge1.TabIndex = 7;
            this.tbMenge1.ToolTipController = this.toolTipController1;
            this.tbMenge1.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbMenge1.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbMenge1.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // tbCharge
            // 
            this.tbCharge.EditValue = "";
            this.tbCharge.Location = new System.Drawing.Point(99, 144);
            this.tbCharge.Name = "tbCharge";
            this.tbCharge.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCharge.Properties.MaxLength = 60;
            this.tbCharge.Size = new System.Drawing.Size(497, 20);
            this.tbCharge.StyleController = this.mainLayoutControl;
            this.tbCharge.TabIndex = 3;
            this.tbCharge.ToolTipController = this.toolTipController1;
            this.tbCharge.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbCharge.Leave += new System.EventHandler(this.tbField_Validated);
            this.tbCharge.Validating += new System.ComponentModel.CancelEventHandler(this.tbField_Validating);
            // 
            // tbInput
            // 
            this.tbInput.EditValue = "";
            this.tbInput.Location = new System.Drawing.Point(99, 120);
            this.tbInput.Name = "tbInput";
            this.tbInput.Properties.NullText = "Artikel scannen";
            this.tbInput.Properties.NullValuePrompt = "Bitte Artikel Scannen";
            this.tbInput.Size = new System.Drawing.Size(497, 20);
            this.tbInput.StyleController = this.mainLayoutControl;
            this.tbInput.TabIndex = 2;
            this.tbInput.ToolTipController = this.toolTipController1;
            this.tbInput.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbInput_InvalidValue);
            this.tbInput.Validating += new System.ComponentModel.CancelEventHandler(this.tbInput_Validating);
            // 
            // lciTbInput
            // 
            this.lciTbInput.Control = this.tbInput;
            this.lciTbInput.CustomizationFormText = "layoutControlItem3";
            this.lciTbInput.Location = new System.Drawing.Point(0, 108);
            this.lciTbInput.Name = "lciTbInput";
            this.lciTbInput.Size = new System.Drawing.Size(588, 24);
            this.lciTbInput.Text = "Eingabe";
            this.lciTbInput.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbCharge
            // 
            this.lciTbCharge.Control = this.tbCharge;
            this.lciTbCharge.CustomizationFormText = "layoutControlItem4";
            this.lciTbCharge.Location = new System.Drawing.Point(0, 132);
            this.lciTbCharge.MaxSize = new System.Drawing.Size(588, 24);
            this.lciTbCharge.MinSize = new System.Drawing.Size(588, 24);
            this.lciTbCharge.Name = "lciTbCharge";
            this.lciTbCharge.Size = new System.Drawing.Size(588, 24);
            this.lciTbCharge.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbCharge.Text = "Charge:";
            this.lciTbCharge.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciKeyboardControlNum
            // 
            this.lciKeyboardControlNum.Control = this.keyboardControlNum;
            this.lciKeyboardControlNum.CustomizationFormText = "lciKeyboard";
            this.lciKeyboardControlNum.Location = new System.Drawing.Point(0, 0);
            this.lciKeyboardControlNum.Name = "lciKeyboardControlNum";
            this.lciKeyboardControlNum.Size = new System.Drawing.Size(588, 130);
            this.lciKeyboardControlNum.TextSize = new System.Drawing.Size(0, 0);
            this.lciKeyboardControlNum.TextVisible = false;
            // 
            // lciLand
            // 
            this.lciLand.Control = this.tbLand;
            this.lciLand.Location = new System.Drawing.Point(0, 156);
            this.lciLand.MaxSize = new System.Drawing.Size(141, 24);
            this.lciLand.MinSize = new System.Drawing.Size(141, 24);
            this.lciLand.Name = "lciLand";
            this.lciLand.Size = new System.Drawing.Size(141, 24);
            this.lciLand.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLand.Text = "Ursprungsland";
            this.lciLand.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbAb1
            // 
            this.lciTbAb1.Control = this.tbAb1;
            this.lciTbAb1.CustomizationFormText = "layoutControlItem7";
            this.lciTbAb1.Location = new System.Drawing.Point(351, 180);
            this.lciTbAb1.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbAb1.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbAb1.Name = "lciTbAb1";
            this.lciTbAb1.Size = new System.Drawing.Size(237, 24);
            this.lciTbAb1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbAb1.Text = "Abmassfeld 1:";
            this.lciTbAb1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbAb2
            // 
            this.lciTbAb2.Control = this.tbAb2;
            this.lciTbAb2.CustomizationFormText = "layoutControlItem8";
            this.lciTbAb2.Location = new System.Drawing.Point(351, 204);
            this.lciTbAb2.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbAb2.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbAb2.Name = "lciTbAb2";
            this.lciTbAb2.Size = new System.Drawing.Size(237, 24);
            this.lciTbAb2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbAb2.Text = "Abmassfeld 2:";
            this.lciTbAb2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbAb3
            // 
            this.lciTbAb3.Control = this.tbAb3;
            this.lciTbAb3.CustomizationFormText = "layoutControlItem9";
            this.lciTbAb3.Location = new System.Drawing.Point(351, 228);
            this.lciTbAb3.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbAb3.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbAb3.Name = "lciTbAb3";
            this.lciTbAb3.Size = new System.Drawing.Size(237, 24);
            this.lciTbAb3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbAb3.Text = "Abmassfeld 3:";
            this.lciTbAb3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbAb4
            // 
            this.lciTbAb4.Control = this.tbAb4;
            this.lciTbAb4.CustomizationFormText = "layoutControlItem10";
            this.lciTbAb4.Location = new System.Drawing.Point(351, 252);
            this.lciTbAb4.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbAb4.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbAb4.Name = "lciTbAb4";
            this.lciTbAb4.Size = new System.Drawing.Size(237, 24);
            this.lciTbAb4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbAb4.Text = "Abmassfeld 4:";
            this.lciTbAb4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbMenge1
            // 
            this.lciTbMenge1.Control = this.tbMenge1;
            this.lciTbMenge1.CustomizationFormText = "layoutControlItem5";
            this.lciTbMenge1.Location = new System.Drawing.Point(0, 228);
            this.lciTbMenge1.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbMenge1.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbMenge1.Name = "lciTbMenge1";
            this.lciTbMenge1.Size = new System.Drawing.Size(237, 24);
            this.lciTbMenge1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbMenge1.Text = "Menge 1:";
            this.lciTbMenge1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciTbMenge2
            // 
            this.lciTbMenge2.Control = this.tbMenge2;
            this.lciTbMenge2.CustomizationFormText = "layoutControlItem6";
            this.lciTbMenge2.Location = new System.Drawing.Point(0, 252);
            this.lciTbMenge2.MaxSize = new System.Drawing.Size(237, 24);
            this.lciTbMenge2.MinSize = new System.Drawing.Size(237, 24);
            this.lciTbMenge2.Name = "lciTbMenge2";
            this.lciTbMenge2.Size = new System.Drawing.Size(237, 24);
            this.lciTbMenge2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTbMenge2.Text = "Menge 2:";
            this.lciTbMenge2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // LciTbSeriennummer
            // 
            this.LciTbSeriennummer.Control = this.tbSeriennummer;
            this.LciTbSeriennummer.Location = new System.Drawing.Point(351, 156);
            this.LciTbSeriennummer.Name = "LciTbSeriennummer";
            this.LciTbSeriennummer.Size = new System.Drawing.Size(237, 24);
            this.LciTbSeriennummer.Text = "Seriennummer :";
            this.LciTbSeriennummer.TextSize = new System.Drawing.Size(75, 13);
            // 
            // MainEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbruch;
            this.ClientSize = new System.Drawing.Size(885, 426);
            this.Controls.Add(this.mainLayoutControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainEditForm.IconOptions.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Erfassung";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            this.mainLayoutControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHerstelldatum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHerstelldatum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerfallsdatum.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerfallsdatum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcArtikelnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcLager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLbBenuzter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcBezeichnung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcMengeGezaeht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLcMengeGezaeht2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnSpeichern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnAbbruch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnResetScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbHerstelldatum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sllMenge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbVerfallsdatum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sllMenge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSeriennummer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAb1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenge2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenge1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyboardControlNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbAb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbMenge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTbMenge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTbSeriennummer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private CustomTextEdit tbInput;
        private DevExpress.XtraEditors.LabelControl lcArtikelnummer;
        private DevExpress.XtraEditors.LabelControl lcLager;
        private DevExpress.XtraLayout.LayoutControlItem lciLcArtikelnummer;
        private DevExpress.XtraLayout.LayoutControlItem lciLcLager;
        private DevExpress.XtraLayout.LayoutControlItem lciTbInput;
        private CustomTextEdit tbAb4;
        private CustomTextEdit tbAb3;
        private CustomTextEdit tbAb2;
        private CustomTextEdit tbAb1;
        private CustomTextEdit tbMenge2;
        private CustomTextEdit tbMenge1;
        private CustomTextEdit tbCharge;
        private DevExpress.XtraLayout.LayoutControlItem lciTbCharge;
        private DevExpress.XtraLayout.LayoutControlItem lciTbMenge1;
        private DevExpress.XtraLayout.LayoutControlItem lciTbMenge2;
        private DevExpress.XtraLayout.LayoutControlItem lciTbAb1;
        private DevExpress.XtraLayout.LayoutControlItem lciTbAb2;
        private DevExpress.XtraLayout.LayoutControlItem lciTbAb3;
        private DevExpress.XtraLayout.LayoutControlItem lciTbAb4;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl keyboardControlNum;
        private DevExpress.XtraLayout.LayoutControlItem lciKeyboardControlNum;
        private DevExpress.XtraLayout.SimpleLabelItem sllMenge1;
        private DevExpress.XtraLayout.SimpleLabelItem sllMenge2;
        private DevExpress.XtraEditors.SimpleButton btnAbbruch;
        private DevExpress.XtraEditors.SimpleButton btnSpeichern;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnSpeichern;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnAbbruch;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.LabelControl lcBezeichnung;
        private DevExpress.XtraLayout.LayoutControlItem lciLcBezeichnung;
        private DevExpress.XtraEditors.SimpleButton btnResetScan;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnResetScan;
        private DevExpress.XtraEditors.LabelControl lcMengeGezaeht;
        private DevExpress.XtraEditors.LabelControl lbBenuzter;
        private DevExpress.XtraLayout.LayoutControlItem lciLbBenuzter;
        private DevExpress.XtraEditors.LabelControl lcMengeGezaeht2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciLcMengeGezaeht;
        private DevExpress.XtraLayout.LayoutControlItem lciLcMengeGezaeht2;
        private CustomTextEdit tbLand;
        private DevExpress.XtraLayout.LayoutControlItem lciLand;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.DateEdit tbHerstelldatum;
        private DevExpress.XtraEditors.DateEdit tbVerfallsdatum;
        private DevExpress.XtraLayout.LayoutControlItem lciTbHerstelldatum;
        private DevExpress.XtraLayout.LayoutControlItem lciTbVerfallsdatum;
        private DevExpress.Utils.ToolTipController toolTipController11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private CustomTextEdit tbSeriennummer;
        private DevExpress.XtraLayout.LayoutControlItem LciTbSeriennummer;
    }
}