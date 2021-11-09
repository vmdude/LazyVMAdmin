using System;
using System.Windows.Forms;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class for about form
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Constructor for about form class
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductName + " " + Application.ProductVersion;
        }
    }
}
