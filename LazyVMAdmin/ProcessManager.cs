using System;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class used for process manage
    /// </summary>
    public partial class ProcessManager
    {
        /// <summary>
        /// Constructor for the process manage class
        /// </summary>
        public ProcessManager() { }

        /// <summary>
        /// Process launch function with specified username
        /// </summary>
        /// <param name="filename">Filepath of the process that will be launch</param>
        /// <param name="args">Arguments that will be used by the process</param>
        /// <param name="login">User name </param>
        /// <param name="password">Password of the user name</param>
        /// <returns>Boolean for launch status, true=launched, false=error</returns>
        public Boolean ImpersonateApplicationExecute(string filename, string args, string login, SecureString password)
        {
            try
            {
                Process process2run = new Process();
                process2run.StartInfo.FileName = filename;
                process2run.StartInfo.Arguments = args;
                process2run.StartInfo.UserName = login;
                process2run.StartInfo.Password = password;
                process2run.StartInfo.UseShellExecute = false;
                return process2run.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Process run error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
