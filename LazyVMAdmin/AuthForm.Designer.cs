using System.Windows.Forms;

namespace LazyVMAdmin
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picAuth = new System.Windows.Forms.PictureBox();
            this.grpAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(73, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(83, 198);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(109, 32);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.TabStop = false;
            this.btnConnection.Text = "Da Connection !";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.lblDomain);
            this.grpAuth.Controls.Add(this.txtDomain);
            this.grpAuth.Controls.Add(this.txtPwd);
            this.grpAuth.Controls.Add(this.lblPwd);
            this.grpAuth.Controls.Add(this.lblLogin);
            this.grpAuth.Controls.Add(this.txtLogin);
            this.grpAuth.Location = new System.Drawing.Point(26, 84);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(270, 108);
            this.grpAuth.TabIndex = 4;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Enter your credentials";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(6, 74);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 6;
            this.lblDomain.Text = "Domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(73, 71);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(180, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(73, 45);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(180, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 48);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(56, 13);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(61, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "User name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picAuth
            // 
            this.picAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAuth.Image = global::LazyVMAdmin.Properties.Resources.auth_ban;
            this.picAuth.Location = new System.Drawing.Point(0, 0);
            this.picAuth.Name = "picAuth";
            this.picAuth.Size = new System.Drawing.Size(319, 242);
            this.picAuth.TabIndex = 5;
            this.picAuth.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 242);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAuth);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.picAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Authentication Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthForm_Keydown);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picAuth;
        private Label lblDomain;
        private TextBox txtDomain;
    }
}