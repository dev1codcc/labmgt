using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DBTester3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {

            DBAccess.SetupConn(DBAccess.GetLocalConnStr());
            if (DBAccess.myConn != null)
            {
                DBAccess.myConn.Open();
            }
            this.richTextBox1.AppendText(DBAccess.myConn.State.ToString() + "\n");
            this.btnFetch.Enabled = true;
        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            string ipAddr = DBAccess.getIpAddr();
            Ping ping = new Ping();
            PingReply pr = ping.Send(this.txtIP.Text.Trim());
            this.richTextBox1.AppendText(pr.Status.ToString() + "\n");

            if (pr.Status == IPStatus.Success)
            {
                //this.richTextBox1.AppendText(DBAccess.getIPConnStr(this.txtIP.Text.Trim())+"\n");
                DBAccess.SetupConn(DBAccess.getIPConnStr(this.txtIP.Text.Trim()));
                if (DBAccess.myConn != null)
                {
                    DBAccess.myConn.Open();
                }
                this.richTextBox1.AppendText(DBAccess.myConn.State.ToString() + "\n");
                this.btnFetch.Enabled = true;
            }


        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter appDA;
            string sqlStr = "select * from appointment2 where bookdate=@bookdate";
            sqlStr = "select top 100 * from appointment2 order by id desc";

            appDA = GetAppointDA(sqlStr, DBAccess.myConnStr, DateTime.Now.ToShortDateString());
            DataSet ds = new DataSet();
            appDA.Fill(ds, "appointment2");

            DataTable tab = ds.Tables[0];

            foreach (DataRow row in tab.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    this.richTextBox1.AppendText(row.ItemArray[i].ToString() + "---");
                }
                this.richTextBox1.AppendText("\n");
            }

            this.btnFetch.Enabled = false;
        }




        public SqlDataAdapter GetAppointDA(string sqlStr, string connStr, string bookdate)
        {
            SqlDataAdapter appDA = new SqlDataAdapter(sqlStr, connStr);
            appDA.SelectCommand.Parameters.Add("@bookdate", SqlDbType.NVarChar, 50);
            appDA.SelectCommand.Parameters["@bookdate"].Value = bookdate;

            //auto construct select, insert, update, delete command in DA
            new SqlCommandBuilder(appDA);
            return appDA;
        }
    }
}
