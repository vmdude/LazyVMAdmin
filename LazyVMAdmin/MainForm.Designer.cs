namespace LazyVMAdmin
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vSphereClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerCLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.authenticationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vSphereClientToolStripMenuItem,
            this.powerCLIToolStripMenuItem,
            this.commandShellToolStripMenuItem,
            this.toolStripSeparator1,
            this.authenticationToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 164);
            // 
            // vSphereClientToolStripMenuItem
            // 
            this.vSphereClientToolStripMenuItem.Enabled = false;
            this.vSphereClientToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.viclient;
            this.vSphereClientToolStripMenuItem.Name = "vSphereClientToolStripMenuItem";
            this.vSphereClientToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.vSphereClientToolStripMenuItem.Text = "vSphere Client";
            this.vSphereClientToolStripMenuItem.Click += new System.EventHandler(this.vSphereClientToolStripMenuItem_Click);
            // 
            // powerCLIToolStripMenuItem
            // 
            this.powerCLIToolStripMenuItem.Enabled = false;
            this.powerCLIToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.powercli;
            this.powerCLIToolStripMenuItem.Name = "powerCLIToolStripMenuItem";
            this.powerCLIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.powerCLIToolStripMenuItem.Text = "PowerCLI";
            this.powerCLIToolStripMenuItem.Click += new System.EventHandler(this.powerCLIToolStripMenuItem_Click);
            // 
            // commandShellToolStripMenuItem
            // 
            this.commandShellToolStripMenuItem.Enabled = false;
            this.commandShellToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.Cmd_icon;
            this.commandShellToolStripMenuItem.Name = "commandShellToolStripMenuItem";
            this.commandShellToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.commandShellToolStripMenuItem.Text = "CommandShell";
            this.commandShellToolStripMenuItem.Click += new System.EventHandler(this.commandShellToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // authenticationToolStripMenuItem
            // 
            this.authenticationToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.auth;
            this.authenticationToolStripMenuItem.Name = "authenticationToolStripMenuItem";
            this.authenticationToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.authenticationToolStripMenuItem.Text = "Authentication";
            this.authenticationToolStripMenuItem.Click += new System.EventHandler(this.authenticationToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.auth;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Visible = false;
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::LazyVMAdmin.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LazyVMAdmin";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vSphereClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerCLIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem authenticationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem commandShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

