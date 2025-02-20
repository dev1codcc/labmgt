using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LabStarter
{
    public partial class frmChangePWD : Form
    {
        public frmChangePWD()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        UsrOps myUsrOps = new UsrOps();

        private void FrmChangePWD_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "id";
            ds = myUsrOps.GetUsrDS();
            comboBox1.DataSource = ds.Tables[0];

            string tabname = ds.Tables[0].TableName;
            int rows = ds.Tables[0].Rows.Count;

            inforBar2.Text = tabname + "#" + rows;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtPwd1.Text.Length < 6)
            {
                inforBar2.Text = "Password length must > 6";
                inforBar2.ForeColor = Color.Red;
            }
            else if (txtPwd1.Text != txtPwd2.Text)
            {
                txtPwd2.ResetText();
                inforBar2.Text = "New Password and re-type must be same";
                inforBar2.ForeColor = Color.Red;
            }
            else
            {
                int cid = Convert.ToInt32(comboBox1.SelectedValue);
                string pwd = txtPwd2.Text;
                bool newlogstatus = chkNewUsr.Checked;
                myUsrOps.UpdateInfo(cid, pwd, newlogstatus);
                txtPwd1.ResetText();
                txtPwd2.ResetText();
                inforBar2.Text = "password changed";
                inforBar2.ForeColor = Color.Blue;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usrname = comboBox1.Text;
            string id = comboBox1.SelectedValue.ToString();
            string newlogin = ds.Tables["users"].Select("id=" + id)[0]["newlogin"].ToString();

            inforBar2.Text = usrname + "#" + id + "# Newlog status:" + newlogin;
        }
    }
}
