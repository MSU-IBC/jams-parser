using System;
using System.Configuration;
using System.Windows.Forms;

namespace JamsParser
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

            if (ConfigurationManager.AppSettings["apiKey"] == "setme")
            {
                MessageBox.Show("Please set api key in configuration.");
                return;
            }

            Application.Run(new MainMenu());
        }
    }
}
