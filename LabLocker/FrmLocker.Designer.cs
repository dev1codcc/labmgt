namespace LabLocker
{
    partial class FrmLocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocker));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldDevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeList = new System.Windows.Forms.Timer(this.components);
            this.nfiLocker = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolStripBar2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolStripBar4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolStripBar5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbMachine = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeControl = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.coldDevi,
            this.colDate,
            this.colHour,
            this.colMin,
            this.colUsr,
            this.colID,
            this.colMon});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // colOrder
            // 
            resources.ApplyResources(this.colOrder, "colOrder");
            // 
            // coldDevi
            // 
            resources.ApplyResources(this.coldDevi, "coldDevi");
            // 
            // colDate
            // 
            resources.ApplyResources(this.colDate, "colDate");
            // 
            // colHour
            // 
            resources.ApplyResources(this.colHour, "colHour");
            // 
            // colMin
            // 
            resources.ApplyResources(this.colMin, "colMin");
            // 
            // colUsr
            // 
            resources.ApplyResources(this.colUsr, "colUsr");
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            // 
            // colMon
            // 
            resources.ApplyResources(this.colMon, "colMon");
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnUnlock
            // 
            resources.ApplyResources(this.btnUnlock, "btnUnlock");
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timeList
            // 
            this.timeList.Interval = 8000;
            this.timeList.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // nfiLocker
            // 
            resources.ApplyResources(this.nfiLocker, "nfiLocker");
            this.nfiLocker.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NfiLocker_MouseDoubleClick);
            // 
            // lbOrder
            // 
            this.lbOrder.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbOrder, "lbOrder");
            this.lbOrder.Name = "lbOrder";
            // 
            // lbOwner
            // 
            this.lbOwner.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbOwner, "lbOwner");
            this.lbOwner.Name = "lbOwner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.lbMachine);
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnUnlock);
            this.groupBox1.Controls.Add(this.lbOwner);
            this.groupBox1.Controls.Add(this.lbOrder);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tolStripBar2,
            this.toolStripStatusLabel2,
            this.tolStripBar4,
            this.toolStripStatusLabel3,
            this.tolStripBar5,
            this.toolStripStatusLabel4,
            this.lbRows});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // tolStripBar2
            // 
            this.tolStripBar2.Name = "tolStripBar2";
            resources.ApplyResources(this.tolStripBar2, "tolStripBar2");
            this.tolStripBar2.Click += new System.EventHandler(this.tolStripBar2_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // tolStripBar4
            // 
            this.tolStripBar4.Name = "tolStripBar4";
            resources.ApplyResources(this.tolStripBar4, "tolStripBar4");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // tolStripBar5
            // 
            this.tolStripBar5.Name = "tolStripBar5";
            resources.ApplyResources(this.tolStripBar5, "tolStripBar5");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // lbRows
            // 
            this.lbRows.Name = "lbRows";
            resources.ApplyResources(this.lbRows, "lbRows");
            // 
            // btnReload
            // 
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbMachine
            // 
            this.lbMachine.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbMachine, "lbMachine");
            this.lbMachine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMachine.Name = "lbMachine";
            this.lbMachine.Tag = "PC1";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbTime, "lbTime");
            this.lbTime.Name = "lbTime";
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbInfo, "lbInfo");
            this.lbInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbInfo.Name = "lbInfo";
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLogin.Name = "lbLogin";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.lbStatus, "lbStatus");
            this.lbStatus.Name = "lbStatus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // timeControl
            // 
            this.timeControl.Enabled = true;
            this.timeControl.Interval = 5000;
            this.timeControl.Tick += new System.EventHandler(this.timeControl_Tick);
            // 
            // FrmLocker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocker";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.FrmLocker_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLocker_FormClosing);
            this.Load += new System.EventHandler(this.Testing_Load);
            this.RegionChanged += new System.EventHandler(this.FrmLocker_RegionChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmLocker_DragDrop);
            this.MouseLeave += new System.EventHandler(this.FrmLocker_MouseLeave);
            this.Move += new System.EventHandler(this.FrmLocker_Move);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timeList;
        private System.Windows.Forms.NotifyIcon nfiLocker;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader coldDevi;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colHour;
        private System.Windows.Forms.ColumnHeader colMin;
        private System.Windows.Forms.ColumnHeader colUsr;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timeControl;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbMachine;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tolStripBar2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tolStripBar4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tolStripBar5;
        private System.Windows.Forms.ColumnHeader colMon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbRows;
    }
}