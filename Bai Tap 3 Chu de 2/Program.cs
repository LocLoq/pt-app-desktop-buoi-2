using System;
using System.Windows.Forms;

namespace Lab02_QuanLySinhVienKhoaCNTT
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
            Application.Run(new frmSinhVienKhoaCNTT());
        }
    }
}
