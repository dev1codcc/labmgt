using System;
using System.Windows.Forms;

namespace LabStarter
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loginUsr();
        }

        private void TxtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginUsr();
            }
        }

        void loginUsr()
        {
            string usr = txtUsr.Text.Trim();
            string pwd = txtPwd.Text;
            if (usr != "")
            {
                if (usr.ToLower() == "admin" && pwd == "45268177")
                {
                    DBAccess.LoginStatus = true;
                    this.Close();
                }
                else
                {
                    DBAccess.LoginStatus = false;
                    txtPwd.ResetText();
                    MessageBox.Show("Wrong user and password, please try again.");
                }
            }
        }
    }
}
