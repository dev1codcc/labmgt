using System;
using System.Windows.Forms;

namespace LabRegisterV1
{
    public partial class FrmVerifyUser : Form
    {

        public FrmVerifyUser()
        {
            InitializeComponent();
        }

        private void VerifyUser_Load(object sender, EventArgs e)
        {
            //FrmMain.VerifyUserResult = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usrname = this.txtUsername.Text.Trim().ToLower();
            string password = this.txtPassword.Text;
            bool chkStatus = UserOps.ExistingUsr(usrname, password);
            if (chkStatus)
            {
                UserOps.LoadUserProfile(usrname, password);
                if (UserOps.UserProfile.NewLogin)
                {
                    NewLoginAction();
                }
                else
                {
                    AfterVerifyAction();
                }

            }
            else
            {
                DBAccess.currentuseranme = DBAccess.nullname;
                //MessageBox.Show("your username or password is incorrect");
                this.txtPassword.ResetText();
                this.txtPassword.ResetText();
                Setinfobar("your username or password is incorrect");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Form1.VerifyUserResult = false;
            this.Close();
        }

        private void ChkChange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChange.Checked)
            {
                panChangePwd.Enabled = true;
            }
            else
            {
                panChangePwd.Enabled = false;
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            string usrname = this.txtUsername.Text;
            string pwd1 = txtNewPwd.Text;
            string pwd2 = txtRePwd.Text;

            if (pwd1.Length < 6)
            {
                Setinfobar("Password length should be >= 6");
            }
            else if (pwd1 == pwd2)
            {
                UserOps.ChangePassword(usrname, pwd1);
                AfterChangeAction();
            }
            else
            {
                txtRePwd.ResetText();
                Setinfobar("New password must be matched.");
            }
        }

        #region set
        void Setinfobar(string text)
        {
            lbInfoBar.Text = "Info: " + text;
        }

        void NewLoginAction()
        {
            panLogin.Enabled = false;
            //Change the password
            chkChange.Checked = true;
            chkChange.Enabled = false;

            Setinfobar("First-time login, please change your password.");
        }

        void AfterVerifyAction()
        {
            panLogin.Enabled = false;
            chkChange.Enabled = true;
            btnLogin2.Enabled = true;
            Setinfobar("Verified successfully. Please login");
        }

        void AfterChangeAction()
        {
            txtPassword.Text = txtRePwd.Text;
            chkChange.Checked = false;
            btnLogin2.Enabled = true;
            Setinfobar("Changed password successfully. Please login");
        }

        void Login()
        {
            //login and exit
            string usrname = this.txtUsername.Text.Trim().ToLower();
            string password = this.txtPassword.Text;
            DBAccess.currentuseranme = usrname;
            UserOps.LoadUserProfile(usrname, password);
            this.Close();
        }
        #endregion

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
