using DevExpress.Data.Mask;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCLAS.MDE
{
    public class CustomTextEdit : TextEdit
    {
        bool alreadyFocused;

        public CustomTextEdit()
        {
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (!alreadyFocused && this.SelectionLength == 0)
            {
                alreadyFocused = true;
                this.SelectAll();

                if (this.Properties.MaskSettings.MaskManagerType == typeof(NumericMaskManager))
                    this.FindParentBaseForm((Control)this)?.SwitchKeyboard(true);
                else
                    this.FindParentBaseForm((Control)this)?.SwitchKeyboard(false);

                //if (this.Properties.Mask.MaskType == DevExpress.XtraEditors.Mask.MaskType.Numeric)
                //{
                //    MainEditForm mef = this.FindParentBaseForm(this);
                //    if (mef != null)
                //    {
                //        mef.SwitchKeyboard(true);
                //    }

                //}
                //else
                //{
                //    MainEditForm mef = this.FindParentBaseForm(this);
                //    if (mef != null)
                //    {
                //        mef.SwitchKeyboard(false);
                //    }                 
                //}
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            if (this.Properties.MaskSettings.MaskManagerType == typeof(NumericMaskManager))
                this.FindParentBaseForm((Control)this)?.SwitchKeyboard(true);
            else
                this.FindParentBaseForm((Control)this)?.SwitchKeyboard(false);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            if (MouseButtons == MouseButtons.None)
            {
                this.SelectAll();
                alreadyFocused = true;

                
                //if (this.Properties.Mask.MaskType == DevExpress.XtraEditors.Mask.MaskType.Numeric)
                //{
                //    MainEditForm mef = this.FindParentBaseForm(this);
                //    if (mef != null)
                //    {
                //        mef.SwitchKeyboard(true);
                //    }
                  
                //}
                //else
                //{
                //    MainEditForm mef = this.FindParentBaseForm(this);
                //    if (mef != null)
                //    {
                //        mef.SwitchKeyboard(false);
                //    }                 
                //}
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            alreadyFocused = false;
        }

        private MainEditForm FindParentBaseForm(Control control)
        {
            Control ctrlParent = control;
            while ((ctrlParent = ctrlParent.Parent) != null)
            {
                if (ctrlParent is MainEditForm)
                {
                    return (MainEditForm)ctrlParent;
                }

            }
            return null;
        }

    }
}
