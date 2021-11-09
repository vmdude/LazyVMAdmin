using System;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;

namespace LazyVMAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check for app.config file
            if (!System.IO.File.Exists(System.Reflection.Assembly.GetEntryAssembly().Location + ".config"))
            {
                MessageBox.Show("The " + System.Reflection.Assembly.GetEntryAssembly().Location + ".config file is missing !", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((ConfigurationManager.AppSettings["CommandShellFileName"] != null)
                & (ConfigurationManager.AppSettings["CommandShellArgs"] != null)
                & (ConfigurationManager.AppSettings["vSphereClientFileName"] != null)
                & (ConfigurationManager.AppSettings["vSphereClientArgs"] != null)
                & (ConfigurationManager.AppSettings["powerCLIFileName"] != null)
                & (ConfigurationManager.AppSettings["powerCLIArgs"] != null))
            {
                MessageBox.Show("Configuration file error !" + Environment.NewLine + "Please check the .config file which must be at the same root than .exe file", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Allow only one instance of this app to be run
                // Use mutex to track app launch
                bool instanceCountOne = false;

                using (Mutex mtex = new Mutex(true, "LazyVMwareAdmin", out instanceCountOne))
                {
                    if (instanceCountOne)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        MainForm form = new MainForm();
                        Application.Run();
                        mtex.ReleaseMutex();
                    }
                }
            }
        }
    }
}
