using System;
using System.Windows.Forms;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class for authentication form
    /// </summary>
    public partial class AuthForm : Form
    {
        private MainForm m_parent;

        /// <summary>
        /// Constructor for authentication form class
        /// </summary>
        /// <param name="Mainfrm">Parent form identifier in order to keep owner/owned relation</param>
        public AuthForm(MainForm Mainfrm)
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.DefaultUsername != "")
                txtLogin.Text = Properties.Settings.Default.DefaultUsername;

            if (Properties.Settings.Default.DefaultDomain != "")
                txtDomain.Text = Properties.Settings.Default.DefaultDomain;

            m_parent = Mainfrm;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            // Check credential provided by user
            ActiveDirectory objAD = new ActiveDirectory();
            if (objAD.ValidateUser(txtDomain.Text, txtLogin.Text, txtPwd.Text))
            {
                m_parent.CMDMenuEnabled = true;
                m_parent.PCLIMenuEnabled = true;
                m_parent.VICLientMenuEnabled = true;
                m_parent.AuthenticationToolStripVisible = false;
                m_parent.DisconnectToolStripVisible = true;

                SecureStringHandler SecStringHandler = new SecureStringHandler();
                m_parent.AuthenticationLogin = txtLogin.Text;
                m_parent.DisconnectToolStripText = "Disconnect (" + txtLogin.Text + ")";
                m_parent.AuthenticationPassword = SecStringHandler.String2SecureString(txtPwd.Text);
                m_parent.AuthenticationDomain = txtDomain.Text;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Authentication failed !", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthForm_Keydown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnConnection_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnCancel_Click(sender, e);
                    break;
            }
        }
    }
}
