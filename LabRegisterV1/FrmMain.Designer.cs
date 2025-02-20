namespace LabRegisterV1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("8:00");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("9:00");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("10:00");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("11:00");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Section 8:00-11:00", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("12:00");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("13:00");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("14:00");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("15:00");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("16:00");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("17:00");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("18:00");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Section 12:00-18:00", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("19:00");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("20:00");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("21:00");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("22:00");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Section 19:00-22:00", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("23:00");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("0:00");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("1:00");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("2:00");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("3:00");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("4:00");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("5:00");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("6:00");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("7:00");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Section 23:00-7:00", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.datPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRenew = new System.Windows.Forms.Button();
            this.lbTbarB = new System.Windows.Forms.Label();
            this.lbTbarA = new System.Windows.Forms.Label();
            this.lbTimeB = new System.Windows.Forms.Label();
            this.lbTimeA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coboxDevice = new System.Windows.Forms.ComboBox();
            this.lbUsr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listVappoint = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colusr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnbook = new System.Windows.Forms.Button();
            this.btnSetUsr = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treHour = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datPicker
            // 
            this.datPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPicker.Location = new System.Drawing.Point(280, 32);
            this.datPicker.Margin = new System.Windows.Forms.Padding(2);
            this.datPicker.Name = "datPicker";
            this.datPicker.Size = new System.Drawing.Size(151, 23);
            this.datPicker.TabIndex = 0;
            this.datPicker.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenew);
            this.groupBox1.Controls.Add(this.lbTbarB);
            this.groupBox1.Controls.Add(this.lbTbarA);
            this.groupBox1.Controls.Add(this.lbTimeB);
            this.groupBox1.Controls.Add(this.lbTimeA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coboxDevice);
            this.groupBox1.Controls.Add(this.datPicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1138, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(450, 32);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(80, 25);
            this.btnRenew.TabIndex = 8;
            this.btnRenew.Text = "Renew Date";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // lbTbarB
            // 
            this.lbTbarB.BackColor = System.Drawing.SystemColors.Info;
            this.lbTbarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTbarB.Location = new System.Drawing.Point(925, 57);
            this.lbTbarB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTbarB.Name = "lbTbarB";
            this.lbTbarB.Size = new System.Drawing.Size(180, 17);
            this.lbTbarB.TabIndex = 7;
            this.lbTbarB.Text = "Booked/Total:";
            // 
            // lbTbarA
            // 
            this.lbTbarA.BackColor = System.Drawing.SystemColors.Info;
            this.lbTbarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTbarA.Location = new System.Drawing.Point(688, 57);
            this.lbTbarA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTbarA.Name = "lbTbarA";
            this.lbTbarA.Size = new System.Drawing.Size(180, 17);
            this.lbTbarA.TabIndex = 6;
            this.lbTbarA.Text = "Booked/Total:";
            // 
            // lbTimeB
            // 
            this.lbTimeB.BackColor = System.Drawing.SystemColors.Info;
            this.lbTimeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeB.Location = new System.Drawing.Point(925, 35);
            this.lbTimeB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeB.Name = "lbTimeB";
            this.lbTimeB.Size = new System.Drawing.Size(181, 15);
            this.lbTimeB.TabIndex = 5;
            this.lbTimeB.Text = "23:00-8:00#";
            // 
            // lbTimeA
            // 
            this.lbTimeA.BackColor = System.Drawing.SystemColors.Info;
            this.lbTimeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeA.Location = new System.Drawing.Point(688, 35);
            this.lbTimeA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeA.Name = "lbTimeA";
            this.lbTimeA.Size = new System.Drawing.Size(180, 15);
            this.lbTimeA.TabIndex = 4;
            this.lbTimeA.Text = "8:00-23:00#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Machine";
            // 
            // coboxDevice
            // 
            this.coboxDevice.BackColor = System.Drawing.SystemColors.Info;
            this.coboxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coboxDevice.FormattingEnabled = true;
            this.coboxDevice.Items.AddRange(new object[] {
            "PC1"});
            this.coboxDevice.Location = new System.Drawing.Point(116, 32);
            this.coboxDevice.Margin = new System.Windows.Forms.Padding(2);
            this.coboxDevice.Name = "coboxDevice";
            this.coboxDevice.Size = new System.Drawing.Size(138, 20);
            this.coboxDevice.TabIndex = 1;
            // 
            // lbUsr
            // 
            this.lbUsr.BackColor = System.Drawing.SystemColors.Info;
            this.lbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUsr.Location = new System.Drawing.Point(598, 25);
            this.lbUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsr.Name = "lbUsr";
            this.lbUsr.Size = new System.Drawing.Size(179, 28);
            this.lbUsr.TabIndex = 3;
            this.lbUsr.Text = "Current User#";
            this.lbUsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1138, 571);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listVappoint);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(204, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(932, 553);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minutes Window";
            // 
            // listVappoint
            // 
            this.listVappoint.CheckBoxes = true;
            this.listVappoint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.colDevice,
            this.colDate,
            this.colHour,
            this.colMin,
            this.colusr,
            this.colMon,
            this.colCID});
            this.listVappoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVappoint.FullRowSelect = true;
            this.listVappoint.HideSelection = false;
            this.listVappoint.Location = new System.Drawing.Point(2, 16);
            this.listVappoint.Margin = new System.Windows.Forms.Padding(2);
            this.listVappoint.Name = "listVappoint";
            this.listVappoint.Size = new System.Drawing.Size(928, 460);
            this.listVappoint.TabIndex = 1;
            this.listVappoint.UseCompatibleStateImageBehavior = false;
            this.listVappoint.View = System.Windows.Forms.View.Details;
            this.listVappoint.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListVappoint_ItemChecked);
            this.listVappoint.SelectedIndexChanged += new System.EventHandler(this.ListVappoint_SelectedIndexChanged);
            // 
            // colOrder
            // 
            this.colOrder.Text = "Order#";
            // 
            // colDevice
            // 
            this.colDevice.Text = "Device";
            this.colDevice.Width = 90;
            // 
            // colDate
            // 
            this.colDate.Text = "Book Date";
            this.colDate.Width = 90;
            // 
            // colHour
            // 
            this.colHour.Text = "Book Hour";
            this.colHour.Width = 90;
            // 
            // colMin
            // 
            this.colMin.Text = "Book Minutes";
            this.colMin.Width = 110;
            // 
            // colusr
            // 
            this.colusr.Text = "Username";
            this.colusr.Width = 110;
            // 
            // colMon
            // 
            this.colMon.Text = "Month";
            // 
            // colCID
            // 
            this.colCID.Text = "Change ID";
            this.colCID.Width = 136;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnbook);
            this.panel1.Controls.Add(this.btnSetUsr);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lbUsr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 476);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnUnbook
            // 
            this.btnUnbook.Enabled = false;
            this.btnUnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbook.Location = new System.Drawing.Point(142, 25);
            this.btnUnbook.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnbook.Name = "btnUnbook";
            this.btnUnbook.Size = new System.Drawing.Size(75, 28);
            this.btnUnbook.TabIndex = 3;
            this.btnUnbook.Text = "Unbook";
            this.btnUnbook.UseVisualStyleBackColor = true;
            this.btnUnbook.Click += new System.EventHandler(this.BtnUnbook_Click);
            // 
            // btnSetUsr
            // 
            this.btnSetUsr.Enabled = false;
            this.btnSetUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUsr.Location = new System.Drawing.Point(43, 25);
            this.btnSetUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetUsr.Name = "btnSetUsr";
            this.btnSetUsr.Size = new System.Drawing.Size(75, 28);
            this.btnSetUsr.TabIndex = 2;
            this.btnSetUsr.Text = "Book";
            this.btnSetUsr.UseVisualStyleBackColor = true;
            this.btnSetUsr.Click += new System.EventHandler(this.BtnSetUsr_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(470, 25);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 28);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login/Logout";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(308, 25);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Load Schedule";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treHour);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(2, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(202, 553);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hours Window";
            // 
            // treHour
            // 
            this.treHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treHour.Enabled = false;
            this.treHour.Location = new System.Drawing.Point(2, 16);
            this.treHour.Margin = new System.Windows.Forms.Padding(2);
            this.treHour.Name = "treHour";
            treeNode1.Name = "tre8";
            treeNode1.Text = "8:00";
            treeNode2.Name = "tre9";
            treeNode2.Text = "9:00";
            treeNode3.Name = "tre10";
            treeNode3.Text = "10:00";
            treeNode4.Name = "tre11";
            treeNode4.Text = "11:00";
            treeNode5.Name = "treA";
            treeNode5.Text = "Section 8:00-11:00";
            treeNode6.Name = "tre12";
            treeNode6.Text = "12:00";
            treeNode7.Name = "tre13";
            treeNode7.Text = "13:00";
            treeNode8.Name = "tre14";
            treeNode8.Text = "14:00";
            treeNode9.Name = "tre15";
            treeNode9.Text = "15:00";
            treeNode10.Name = "tre16";
            treeNode10.Text = "16:00";
            treeNode11.Name = "rtn17";
            treeNode11.Text = "17:00";
            treeNode12.Name = "tre18";
            treeNode12.Text = "18:00";
            treeNode13.Name = "treB";
            treeNode13.Text = "Section 12:00-18:00";
            treeNode14.Name = "tre19";
            treeNode14.Text = "19:00";
            treeNode15.Name = "tre20";
            treeNode15.Text = "20:00";
            treeNode16.Name = "tre21";
            treeNode16.Text = "21:00";
            treeNode17.Name = "tre22";
            treeNode17.Text = "22:00";
            treeNode18.Name = "treC";
            treeNode18.Text = "Section 19:00-22:00";
            treeNode19.Name = "tre23";
            treeNode19.Text = "23:00";
            treeNode20.Name = "tre0";
            treeNode20.Text = "0:00";
            treeNode21.Name = "tre1";
            treeNode21.Text = "1:00";
            treeNode22.Name = "tre2";
            treeNode22.Text = "2:00";
            treeNode23.Name = "tre3";
            treeNode23.Text = "3:00";
            treeNode24.Name = "tre4";
            treeNode24.Text = "4:00";
            treeNode25.Name = "tre5";
            treeNode25.Text = "5:00";
            treeNode26.Name = "tre6";
            treeNode26.Text = "6:00";
            treeNode27.Name = "tre7";
            treeNode27.Text = "7:00";
            treeNode28.Name = "treD";
            treeNode28.Text = "Section 23:00-7:00";
            this.treHour.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode13,
            treeNode18,
            treeNode28});
            this.treHour.Size = new System.Drawing.Size(198, 535);
            this.treHour.TabIndex = 0;
            this.treHour.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 683);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huaxi Laboratory Appointment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coboxDevice;
        private System.Windows.Forms.TreeView treHour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView listVappoint;
        private System.Windows.Forms.Button btnSetUsr;
        private System.Windows.Forms.Label lbUsr;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader colDevice;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colHour;
        private System.Windows.Forms.ColumnHeader colMin;
        private System.Windows.Forms.ColumnHeader colusr;
        private System.Windows.Forms.ColumnHeader colCID;
        private System.Windows.Forms.Button btnUnbook;
        private System.Windows.Forms.Label lbTimeB;
        private System.Windows.Forms.Label lbTimeA;
        private System.Windows.Forms.Label lbTbarB;
        private System.Windows.Forms.Label lbTbarA;
        private System.Windows.Forms.ColumnHeader colMon;
        private System.Windows.Forms.Button btnRenew;
    }
}

