using System;
using System.Windows.Forms;
using System.Security;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class for Main form and systray notify icon
    /// </summary>
    public partial class MainForm : Form
    {
        AuthForm authFrm;
        private string _authLogin;
        private SecureString _authPwd;
        private string _authDomain;

        /// <summary>
        /// Constructor for main form class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.Hide();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        /// <summary>
        /// Handle global variable storing login field
        /// </summary>
        public String AuthenticationLogin
        {
            get { return _authLogin; }
            set { _authLogin = value; }
        }

        /// <summary>
        /// Handle global variable storing password field
        /// </summary>
        public SecureString AuthenticationPassword
        {
            get { return _authPwd; }
            set { _authPwd = value; }
        }

        /// <summary>
        /// Handle global variable storing domain field
        /// </summary>
        public String AuthenticationDomain
        {
            get { return _authDomain; }
            set { _authDomain = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for command shell
        /// get/set for Enabled property
        /// </summary>
        public Boolean CMDMenuEnabled
        {
            get { return commandShellToolStripMenuItem.Enabled; }
            set { commandShellToolStripMenuItem.Enabled = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for Power CLI
        /// get/set for Enabled property
        /// </summary>
        public Boolean PCLIMenuEnabled
        {
            get { return powerCLIToolStripMenuItem.Enabled; }
            set { powerCLIToolStripMenuItem.Enabled = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for vSphere Client
        /// get/set for Enabled property
        /// </summary>
        public Boolean VICLientMenuEnabled
        {
            get { return vSphereClientToolStripMenuItem.Enabled; }
            set { vSphereClientToolStripMenuItem.Enabled = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for authentication form
        /// get/set for Visible property
        /// </summary>
        public Boolean AuthenticationToolStripVisible
        {
            get { return authenticationToolStripMenuItem.Visible; }
            set { authenticationToolStripMenuItem.Visible = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for disconnect item
        /// get/set for Visible property
        /// </summary>
        public Boolean DisconnectToolStripVisible
        {
            get { return disconnectToolStripMenuItem.Visible; }
            set { disconnectToolStripMenuItem.Visible = value; }
        }

        /// <summary>
        /// Handle Toolstrip menu item for disconnect item
        /// get/set for Text property
        /// </summary>
        public string DisconnectToolStripText
        {
            get { return disconnectToolStripMenuItem.Text; }
            set { disconnectToolStripMenuItem.Text = value; }
        }

        private void authenticationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authFrm = new AuthForm(this);
            authFrm.ShowDialog();
        }

        private void commandShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager pman = new ProcessManager();
            pman.ImpersonateApplicationExecute(Properties.Settings.Default.CommandShellFileName, Properties.Settings.Default.CommandShellArgs, _authLogin, _authPwd);
        }

        private void vSphereClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager pman = new ProcessManager();
            pman.ImpersonateApplicationExecute(Properties.Settings.Default.vSphereClientFileName, Properties.Settings.Default.vSphereClientArgs, _authLogin, _authPwd);
        }

        private void powerCLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager pman = new ProcessManager();
            pman.ImpersonateApplicationExecute(Properties.Settings.Default.powerCLIFileName, Properties.Settings.Default.powerCLIArgs, _authLogin, _authPwd);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _authLogin = null;
            _authPwd = null;
            AuthenticationToolStripVisible = true;
            DisconnectToolStripVisible = false;
            CMDMenuEnabled = false;
            PCLIMenuEnabled = false;
            VICLientMenuEnabled = false;
            MessageBox.Show("Disconnected", "Connection status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutFrm = new AboutForm();
            aboutFrm.ShowDialog();
        }
    }
}
