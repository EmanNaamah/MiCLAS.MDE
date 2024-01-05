using DevExpress.XtraEditors;
namespace MiCLAS.MDE
{
    partial class LagerDlg
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
                this.textEdit1.InvalidValue -= new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.textEdit1_InvalidValue);
                this.textEdit1.Validating -= new System.ComponentModel.CancelEventHandler(this.textEdit1_Validating);
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.keyboardControlNum = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.keyboardControlNum);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Size = new System.Drawing.Size(658, 318);
            this.panelControl1.Controls.SetChildIndex(this.textEdit1, 0);
            this.panelControl1.Controls.SetChildIndex(this.labelControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.keyboardControlNum, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnAbbruch, 0);
            this.panelControl1.Controls.SetChildIndex(this.btnOK, 0);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(571, 12);
            this.btnOK.TabIndex = 1;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.CausesValidation = false;
            this.btnAbbruch.Location = new System.Drawing.Point(571, 93);
            this.btnAbbruch.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(127, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit1.Size = new System.Drawing.Size(281, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.ToolTipController = this.toolTipController1;
            this.textEdit1.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.textEdit1_InvalidValue);
            this.textEdit1.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit1_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Lagerfach (L#O#M):";
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
            this.keyboardControlNum.IsTopBarVisible = false;
            this.keyboardControlNum.Location = new System.Drawing.Point(12, 38);
            this.keyboardControlNum.Name = "keyboardControlNum";
            flatStyleRenderer1.ColorTable = virtualKeyboardColorTable1;
            flatStyleRenderer1.ForceAntiAlias = false;
            this.keyboardControlNum.Renderer = flatStyleRenderer1;
            this.keyboardControlNum.Size = new System.Drawing.Size(517, 265);
            this.keyboardControlNum.TabIndex = 15;
            this.keyboardControlNum.TabStop = false;
            this.keyboardControlNum.Text = "keyboardControl1";
            // 
            // LagerDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(658, 318);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LagerDlg";
            this.Text = "Lager eingeben";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl keyboardControlNum;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}