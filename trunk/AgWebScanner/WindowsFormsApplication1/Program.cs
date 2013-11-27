using System;
using System.Windows.Forms;

namespace AgWebScanner
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
            //Properties.Settings.Default.Registered = false; // used to reset settings
            if (!Properties.Settings.Default.Registered)
            {
                Application.Run(new KeyCheck());
            }
            else 
            {
                //Properties.Settings.Default.Registered = false;
                //Properties.Settings.Default.Save();
                Application.Run(new FmScanner());
            }
        }
    }
}
