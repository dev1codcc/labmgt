
namespace LabStarter
{
    partial class FrmSetHolidays
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnC = new System.Windows.Forms.MonthCalendar();
            this.lvHoliday = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimecode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TimeA(8:00-23:00) 300 Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "TimeB(23:00-8:00) 300 Minutes";
            // 
            // mnC
            // 
            this.mnC.Location = new System.Drawing.Point(31, 120);
            this.mnC.Name = "mnC";
            this.mnC.TabIndex = 0;
            this.mnC.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lvHoliday
            // 
            this.lvHoliday.CheckBoxes = true;
            this.lvHoliday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colActive,
            this.colDat,
            this.colTimecode});
            this.lvHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHoliday.HideSelection = false;
            this.lvHoliday.Location = new System.Drawing.Point(337, 0);
            this.lvHoliday.Name = "lvHoliday";
            this.lvHoliday.Size = new System.Drawing.Size(635, 737);
            this.lvHoliday.TabIndex = 7;
            this.lvHoliday.UseCompatibleStateImageBehavior = false;
            this.lvHoliday.View = System.Windows.Forms.View.Details;
            this.lvHoliday.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvHoliday_ItemChecked);
            this.lvHoliday.SelectedIndexChanged += new System.EventHandler(this.lvHoliday_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 112;
            // 
            // colActive
            // 
            this.colActive.Text = "Acitve";
            this.colActive.Width = 165;
            // 
            // colDat
            // 
            this.colDat.Text = "Date";
            this.colDat.Width = 103;
            // 
            // colTimecode
            // 
            this.colTimecode.Text = "Timecode";
            this.colTimecode.Width = 138;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.mnC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 737);
            this.panel1.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(31, 365);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(262, 48);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Reload Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(31, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRm
            // 
            this.btnRm.Enabled = false;
            this.btnRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRm.Location = new System.Drawing.Point(31, 543);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(262, 48);
            this.btnRm.TabIndex = 10;
            this.btnRm.Text = "Remove";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(31, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(262, 48);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Mark the repeated items";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmSetHolidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 737);
            this.Controls.Add(this.lvHoliday);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSetHolidays";
            this.Text = "Holidays Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSetHolidays_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mnC;
        private System.Windows.Forms.ListView lvHoliday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colActive;
        private System.Windows.Forms.ColumnHeader colDat;
        private System.Windows.Forms.ColumnHeader colTimecode;
    }
}