using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LabStarter
{
    public partial class FrmSetHolidays : Form
    {
        public FrmSetHolidays()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lvHoliday.Items.Add("00");
            int i = lvHoliday.Items.Count;
            i = i - 1;

            lvHoliday.Items[i].SubItems.Add("True");
            lvHoliday.Items[i].SubItems.Add(mnC.SelectionStart.ToShortDateString());
            lvHoliday.Items[i].SubItems.Add("pub001");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Reload();
        }

        //reload data
        void Reload()
        {
            DataTable tab = new DataTable("timedat");
            da.Fill(tab);

            lvHoliday.Items.Clear();

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                lvHoliday.Items.Add(tab.Rows[i][0].ToString());
                lvHoliday.Items[i].SubItems.Add(tab.Rows[i][1].ToString());
                lvHoliday.Items[i].SubItems.Add(tab.Rows[i][2].ToString());
                lvHoliday.Items[i].SubItems.Add(tab.Rows[i][3].ToString());
            }
        }

        #region db ops
        SqlDataAdapter da;
        #endregion

        private void FrmSetHolidays_Load(object sender, EventArgs e)
        {
            Timedat datops = new Timedat();
            da = datops.ReturnTimedatDA();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string curDat;
            string inxDat;

            if (lvHoliday.Items.Count >= 2)
            {
                for (int i = 0; i < lvHoliday.Items.Count; i++)
                {
                    curDat = lvHoliday.Items[i].SubItems[2].Text;
                    for (int j = i + 1; j < lvHoliday.Items.Count; j++)
                    {
                        inxDat = lvHoliday.Items[j].SubItems[2].Text;
                        if (inxDat == curDat)
                        {
                            lvHoliday.Items[j].Checked = true;
                            btnRm.Enabled = true;
                        }
                    }
                }
            }

            if (btnRm.Enabled)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvHoliday.Items)
            {
                if (itm.Checked)
                {
                    itm.Remove();
                }
            }
            btnRm.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlDel = "delete from timedat";
            SqlConnection conn = new SqlConnection(DBAccess.connStr);
            SqlCommand cmd = new SqlCommand(sqlDel, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string sql = "select * from timedat";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBAccess.connStr);
            new SqlCommandBuilder(da);

            DataTable tab = new DataTable("timedat");
            da.Fill(tab);

            //Add data to table
            foreach (ListViewItem itm in lvHoliday.Items)
            {
                DataRow row = tab.NewRow();
                string active = itm.SubItems[1].Text;
                if (active.ToLower() == "true")
                {
                    row[1] = true;
                }
                else
                {
                    row[1] = false;
                }
                row[2] = itm.SubItems[2].Text;
                row[3] = itm.SubItems[3].Text;
                tab.Rows.Add(row);
            }

            //update to db
            da.Update(tab);

            //reload data
            Reload();

            //disable sav button
            btnSave.Enabled = false;
        }

        private void lvHoliday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvHoliday_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            btnRm.Enabled = true;
            btnSave.Enabled = false;
        }
    }
}
