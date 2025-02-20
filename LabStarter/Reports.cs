using System.Data;
using System.Data.SqlClient;

namespace LabStarter
{
    class Reports
    {
        string sqlUsr = "select * from users";
        string sqlAppoinByDate = "select * from appointment2 where bookDate=@bookdate and username=@username";
        string sqlAppoinByMonth = "select * from appointment2 where mon=@mon and username=@username";

        public DataTable GetUsrTable()
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlUsr, DBAccess.connStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "users");

            return ds.Tables["users"];
        }

        public DataTable GetAppoinTableByDate(string dat, string usrname)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlAppoinByDate, DBAccess.connStr);
            da.SelectCommand.Parameters.Add("@bookdate", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@bookdate"].Value = dat;
            da.SelectCommand.Parameters["@username"].Value = usrname;


            DataSet ds = new DataSet();
            da.Fill(ds, "appointment2");

            return ds.Tables["appointment2"];
        }

        public DataTable GetAppoinTableByMonth(int mon, string usrname)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlAppoinByMonth, DBAccess.connStr);
            da.SelectCommand.Parameters.Add("@mon", SqlDbType.Int, 4);
            da.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@mon"].Value = mon;
            da.SelectCommand.Parameters["@username"].Value = usrname;


            DataSet ds = new DataSet();
            da.Fill(ds, "appointment2");

            return ds.Tables["appointment2"];
        }
    }
}
