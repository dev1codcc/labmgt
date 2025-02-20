using System;
using System.Windows.Forms;

namespace LabStarter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void AdminToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SubMnuChange_Click(object sender, EventArgs e)
        {
            frmChangePWD frmChPwd = new frmChangePWD();
            frmChPwd.MdiParent = this;
            frmChPwd.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBAccess.LoginStatus = false;
            subMnuChange.Enabled = false;
            subMnuExport.Enabled = false;
            subMnuSetHoliday.Enabled = false;
            subMnuLogin.Enabled = true;
            subMnuLogout.Enabled = false;
        }

        private void SubMnuLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            if (DBAccess.LoginStatus)
            {
                subMnuChange.Enabled = true;
                subMnuExport.Enabled = true;
                subMnuSetHoliday.Enabled = true;
                subMnuLogin.Enabled = false;
                subMnuLogout.Enabled = true;

            }
        }

        private void SubMnuExport_Click(object sender, EventArgs e)
        {
            ReportUI rptUI = new ReportUI();
            rptUI.MdiParent = this;
            rptUI.WindowState = FormWindowState.Maximized;
            rptUI.Show();
        }

        private void subMnuSetHoliday_Click(object sender, EventArgs e)
        {
            FrmSetHolidays frmHoliday = new FrmSetHolidays();
            frmHoliday.MdiParent = this;
            frmHoliday.Show();
        }
    }
}
