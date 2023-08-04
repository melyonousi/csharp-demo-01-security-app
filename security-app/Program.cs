using System;
using System.Windows.Forms;

namespace security_app
{
    static class Program
    {
        public static string roleName = "";
        public static int idRole;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmActivateKey());
        }
    }
}
