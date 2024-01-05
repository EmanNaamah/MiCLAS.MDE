using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;
using MiCLAS.MDE.Base;
using System.Drawing;
using DevExpress.XtraEditors;

namespace MiCLAS.MDE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DevExpress.Skins.SkinManager.EnableFormSkins();

            WindowsFormsSettings.SetPerMonitorDpiAware();
            WindowsFormsSettings.ForceDirectXPaint();



            FileInfo fi = new FileInfo(Application.StartupPath + "\\Data\\MDEInventur.mdb");

            if (!fi.Exists)
            {
                MyXtraMessageBox.Show("MDEInventur.mdb nicht vorhanden. Inventur kann nicht gestartet werden");
                return;
            }

            if (fi.Exists && fi.IsReadOnly)
            {
                MyXtraMessageBox.Show("MDEInventur.mdb ist schreibgeschüzt. Inventur kann nicht gestartet werden");
                return;
            }

            if (fi.Exists)
            {
                if (File.Exists("MDEInventur.ldb"))
                {
                    MyXtraMessageBox.Show("MDEInventur.mdb ist gesperrt. Inventur kann nicht gestartet werden");
                    return;
                }
            }

            Application.Run(new MainForm());
        }
    }
}
