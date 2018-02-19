using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace _4Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Sikkerhed for der findes en config file.
            var appConfigPath = String.Concat( Assembly.GetEntryAssembly().Location , ".config");
            if (!File.Exists(appConfigPath ) )
            {
                System.IO.File.WriteAllText(appConfigPath, String.Join(Environment.NewLine, "<?xml version=\"1.0\" encoding=\"utf-8\" ?>", "<configuration>", "</configuration>"));
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }        
    }
}
