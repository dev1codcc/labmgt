namespace LabStarter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.adminToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subMnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuSetHoliday = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 30);
            this.mnuMain.TabIndex = 7;
            this.mnuMain.Text = "mnuMain";
            // 
            // adminToolsToolStripMenuItem
            // 
            this.adminToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuChange,
            this.subMnuExport,
            this.subMnuSetHoliday,
            this.toolStripSeparator1,
            this.subMnuLogin,
            this.subMnuLogout});
            this.adminToolsToolStripMenuItem.Name = "adminToolsToolStripMenuItem";
            this.adminToolsToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.adminToolsToolStripMenuItem.Text = "Admin Tools";
            this.adminToolsToolStripMenuItem.Click += new System.EventHandler(this.AdminToolsToolStripMenuItem_Click);
            // 
            // subMnuChange
            // 
            this.subMnuChange.Enabled = false;
            this.subMnuChange.Name = "subMnuChange";
            this.subMnuChange.Size = new System.Drawing.Size(224, 26);
            this.subMnuChange.Text = "Change Password";
            this.subMnuChange.Click += new System.EventHandler(this.SubMnuChange_Click);
            // 
            // subMnuExport
            // 
            this.subMnuExport.Enabled = false;
            this.subMnuExport.Name = "subMnuExport";
            this.subMnuExport.Size = new System.Drawing.Size(224, 26);
            this.subMnuExport.Text = "Export Report";
            this.subMnuExport.Click += new System.EventHandler(this.SubMnuExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // subMnuLogin
            // 
            this.subMnuLogin.Name = "subMnuLogin";
            this.subMnuLogin.Size = new System.Drawing.Size(224, 26);
            this.subMnuLogin.Text = "Login";
            this.subMnuLogin.Click += new System.EventHandler(this.SubMnuLogin_Click);
            // 
            // subMnuLogout
            // 
            this.subMnuLogout.Enabled = false;
            this.subMnuLogout.Name = "subMnuLogout";
            this.subMnuLogout.Size = new System.Drawing.Size(224, 26);
            this.subMnuLogout.Text = "Logout";
            this.subMnuLogout.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // subMnuSetHoliday
            // 
            this.subMnuSetHoliday.Enabled = false;
            this.subMnuSetHoliday.Name = "subMnuSetHoliday";
            this.subMnuSetHoliday.Size = new System.Drawing.Size(224, 26);
            this.subMnuSetHoliday.Text = "Setup Holidays";
            this.subMnuSetHoliday.Click += new System.EventHandler(this.subMnuSetHoliday_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Lab Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem adminToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMnuChange;
        private System.Windows.Forms.ToolStripMenuItem subMnuExport;
        private System.Windows.Forms.ToolStripMenuItem subMnuLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem subMnuLogin;
        private System.Windows.Forms.ToolStripMenuItem subMnuSetHoliday;
    }
}

