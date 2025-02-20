namespace LabStarter
{
    partial class ReportUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRpt = new System.Windows.Forms.Button();
            this.cobUsers = new System.Windows.Forms.ComboBox();
            this.datP = new System.Windows.Forms.DateTimePicker();
            this.Report = new System.Windows.Forms.GroupBox();
            this.dGview = new System.Windows.Forms.DataGridView();
            this.infoBars = new System.Windows.Forms.StatusStrip();
            this.infoBar1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoBar2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rBtnDate = new System.Windows.Forms.RadioButton();
            this.rBtnMon = new System.Windows.Forms.RadioButton();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).BeginInit();
            this.infoBars.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combMon);
            this.groupBox1.Controls.Add(this.rBtnMon);
            this.groupBox1.Controls.Add(this.rBtnDate);
            this.groupBox1.Controls.Add(this.btnRpt);
            this.groupBox1.Controls.Add(this.cobUsers);
            this.groupBox1.Controls.Add(this.datP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // btnRpt
            // 
            this.btnRpt.Location = new System.Drawing.Point(610, 89);
            this.btnRpt.Name = "btnRpt";
            this.btnRpt.Size = new System.Drawing.Size(119, 24);
            this.btnRpt.TabIndex = 3;
            this.btnRpt.Text = "Report";
            this.btnRpt.UseVisualStyleBackColor = true;
            this.btnRpt.Click += new System.EventHandler(this.BtnRpt_Click);
            // 
            // cobUsers
            // 
            this.cobUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobUsers.FormattingEnabled = true;
            this.cobUsers.Location = new System.Drawing.Point(371, 89);
            this.cobUsers.Name = "cobUsers";
            this.cobUsers.Size = new System.Drawing.Size(167, 24);
            this.cobUsers.TabIndex = 1;
            // 
            // datP
            // 
            this.datP.Enabled = false;
            this.datP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datP.Location = new System.Drawing.Point(112, 41);
            this.datP.Name = "datP";
            this.datP.Size = new System.Drawing.Size(183, 22);
            this.datP.TabIndex = 0;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.dGview);
            this.Report.Controls.Add(this.infoBars);
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report.Location = new System.Drawing.Point(0, 143);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1139, 500);
            this.Report.TabIndex = 1;
            this.Report.TabStop = false;
            this.Report.Text = "Report";
            // 
            // dGview
            // 
            this.dGview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGview.Location = new System.Drawing.Point(3, 18);
            this.dGview.Name = "dGview";
            this.dGview.RowHeadersWidth = 51;
            this.dGview.RowTemplate.Height = 24;
            this.dGview.Size = new System.Drawing.Size(1133, 453);
            this.dGview.TabIndex = 1;
            // 
            // infoBars
            // 
            this.infoBars.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infoBars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoBar1,
            this.infoBar2});
            this.infoBars.Location = new System.Drawing.Point(3, 471);
            this.infoBars.Name = "infoBars";
            this.infoBars.Size = new System.Drawing.Size(1133, 26);
            this.infoBars.TabIndex = 0;
            // 
            // infoBar1
            // 
            this.infoBar1.Name = "infoBar1";
            this.infoBar1.Size = new System.Drawing.Size(38, 20);
            this.infoBar1.Text = "Info:";
            // 
            // infoBar2
            // 
            this.infoBar2.Name = "infoBar2";
            this.infoBar2.Size = new System.Drawing.Size(67, 20);
            this.infoBar2.Text = "Message";
            // 
            // rBtnDate
            // 
            this.rBtnDate.AutoSize = true;
            this.rBtnDate.Location = new System.Drawing.Point(27, 42);
            this.rBtnDate.Name = "rBtnDate";
            this.rBtnDate.Size = new System.Drawing.Size(79, 21);
            this.rBtnDate.TabIndex = 4;
            this.rBtnDate.Text = "By Date";
            this.rBtnDate.UseVisualStyleBackColor = true;
            // 
            // rBtnMon
            // 
            this.rBtnMon.AutoSize = true;
            this.rBtnMon.Checked = true;
            this.rBtnMon.Location = new System.Drawing.Point(27, 89);
            this.rBtnMon.Name = "rBtnMon";
            this.rBtnMon.Size = new System.Drawing.Size(79, 21);
            this.rBtnMon.TabIndex = 6;
            this.rBtnMon.TabStop = true;
            this.rBtnMon.Text = "By Date";
            this.rBtnMon.UseVisualStyleBackColor = true;
            this.rBtnMon.CheckedChanged += new System.EventHandler(this.rBtnMon_CheckedChanged);
            // 
            // combMon
            // 
            this.combMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMon.FormattingEnabled = true;
            this.combMon.Location = new System.Drawing.Point(112, 89);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(183, 24);
            this.combMon.TabIndex = 7;
            this.combMon.SelectedIndexChanged += new System.EventHandler(this.combMon_SelectedIndexChanged);
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 643);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportUI";
            this.Text = "ReportUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).EndInit();
            this.infoBars.ResumeLayout(false);
            this.infoBars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobUsers;
        private System.Windows.Forms.DateTimePicker datP;
        private System.Windows.Forms.GroupBox Report;
        private System.Windows.Forms.StatusStrip infoBars;
        private System.Windows.Forms.ToolStripStatusLabel infoBar2;
        private System.Windows.Forms.ToolStripStatusLabel infoBar1;
        private System.Windows.Forms.Button btnRpt;
        private System.Windows.Forms.DataGridView dGview;
        private System.Windows.Forms.RadioButton rBtnMon;
        private System.Windows.Forms.RadioButton rBtnDate;
        private System.Windows.Forms.ComboBox combMon;
    }
}