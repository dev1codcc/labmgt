namespace LabRegisterV1
{
    partial class FrmVerifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerifyUser));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panChangePwd = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.panLogin = new System.Windows.Forms.Panel();
            this.chkChange = new System.Windows.Forms.CheckBox();
            this.lbInfoBar = new System.Windows.Forms.Label();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.panChangePwd.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUsername.Location = new System.Drawing.Point(177, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassword.Location = new System.Drawing.Point(177, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(116, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verify User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtNewPwd.Location = new System.Drawing.Point(180, 13);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(116, 21);
            this.txtNewPwd.TabIndex = 6;
            // 
            // txtRePwd
            // 
            this.txtRePwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRePwd.Location = new System.Drawing.Point(180, 46);
            this.txtRePwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(116, 21);
            this.txtRePwd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Re-type";
            // 
            // panChangePwd
            // 
            this.panChangePwd.Controls.Add(this.btnChange);
            this.panChangePwd.Controls.Add(this.label3);
            this.panChangePwd.Controls.Add(this.txtRePwd);
            this.panChangePwd.Controls.Add(this.label4);
            this.panChangePwd.Controls.Add(this.txtNewPwd);
            this.panChangePwd.Enabled = false;
            this.panChangePwd.Location = new System.Drawing.Point(34, 204);
            this.panChangePwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panChangePwd.Name = "panChangePwd";
            this.panChangePwd.Size = new System.Drawing.Size(412, 123);
            this.panChangePwd.TabIndex = 10;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(104, 79);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(188, 28);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.label1);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Controls.Add(this.button1);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Location = new System.Drawing.Point(34, 26);
            this.panLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(412, 125);
            this.panLogin.TabIndex = 12;
            // 
            // chkChange
            // 
            this.chkChange.AutoSize = true;
            this.chkChange.Enabled = false;
            this.chkChange.Location = new System.Drawing.Point(34, 184);
            this.chkChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkChange.Name = "chkChange";
            this.chkChange.Size = new System.Drawing.Size(114, 16);
            this.chkChange.TabIndex = 13;
            this.chkChange.Text = "Change Password";
            this.chkChange.UseVisualStyleBackColor = true;
            this.chkChange.CheckedChanged += new System.EventHandler(this.ChkChange_CheckedChanged);
            // 
            // lbInfoBar
            // 
            this.lbInfoBar.BackColor = System.Drawing.SystemColors.Info;
            this.lbInfoBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbInfoBar.Location = new System.Drawing.Point(34, 341);
            this.lbInfoBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoBar.Name = "lbInfoBar";
            this.lbInfoBar.Size = new System.Drawing.Size(412, 22);
            this.lbInfoBar.TabIndex = 14;
            this.lbInfoBar.Text = "Info:";
            // 
            // btnLogin2
            // 
            this.btnLogin2.Enabled = false;
            this.btnLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.Location = new System.Drawing.Point(136, 386);
            this.btnLogin2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(188, 28);
            this.btnLogin2.TabIndex = 13;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.UseVisualStyleBackColor = true;
            this.btnLogin2.Click += new System.EventHandler(this.BtnLogin2_Click);
            // 
            // FrmVerifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 447);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.lbInfoBar);
            this.Controls.Add(this.chkChange);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panChangePwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VerifyUser_Load);
            this.panChangePwd.ResumeLayout(false);
            this.panChangePwd.PerformLayout();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panChangePwd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.CheckBox chkChange;
        private System.Windows.Forms.Label lbInfoBar;
        private System.Windows.Forms.Button btnLogin2;
    }
}