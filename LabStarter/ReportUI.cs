using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace LabStarter
{
    public partial class ReportUI : Form
    {
        public ReportUI()
        {
            InitializeComponent();
        }

        private void ReportUI_Load(object sender, EventArgs e)
        {
            Reports rptOps = new Reports();
            DataTable tabUsr = rptOps.GetUsrTable();
            infoBar2.Text = tabUsr.TableName + "#Rows#" + tabUsr.Rows.Count;

            cobUsers.DisplayMember = "username";
            cobUsers.ValueMember = "id";
            cobUsers.DataSource = tabUsr;

            //Fill the month list for combox
            DataTable tab = new DataTable("mon");
            tab.Columns.Add("MonthName");
            tab.Columns.Add("MonthID");

            DataRow rw;

            string[] monStrs = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int i = 1;
            foreach (string monname in monStrs)
            {
                rw = tab.NewRow();
                rw["MonthName"] = monname;
                rw["MonthID"] = i;
                tab.Rows.Add(rw);
                i++;
            }

            combMon.DisplayMember = "MonthName";
            combMon.ValueMember = "MonthID";
            combMon.DataSource = tab;
        }



        private void BtnRpt_Click(object sender, EventArgs e)
        {
            string dat = this.datP.Value.ToShortDateString();
            string usrname = this.cobUsers.Text;

            int mon = Convert.ToInt32(combMon.SelectedValue);

            Reports rptOps = new Reports();
            DataTable tabAppoint;

            if (rBtnDate.Checked)
            {
                tabAppoint = rptOps.GetAppoinTableByDate(dat, usrname);
            }
            else
            {
                tabAppoint = rptOps.GetAppoinTableByMonth(mon, usrname);
            }

            this.dGview.DataSource = tabAppoint;

            infoBar2.Text = tabAppoint.TableName + "#Rows#" + tabAppoint.Rows.Count;
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {

        }

        private void rBtnMon_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMon.Checked)
            {
                combMon.Enabled = true;
                datP.Enabled = false;
            }
            else
            {
                combMon.Enabled = false;
                datP.Enabled = true;
            }
        }

        private void combMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(combMon.Text);
            Debug.WriteLine(combMon.SelectedValue);
        }
    }
}
