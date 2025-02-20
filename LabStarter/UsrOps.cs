using System.Data;
using System.Data.SqlClient;

namespace LabStarter
{
    class UsrOps
    {
        string sqlAll = "select * from users";
        //string sqlT1 = "select top 1 * from users";

        SqlDataAdapter myDA;
        DataSet myDS;

        void GetUsrDA(string sql)
        {
            myDA = new SqlDataAdapter(sql, DBAccess.connStr);
            new SqlCommandBuilder(myDA);
        }

        public DataSet GetUsrDS()
        {
            GetUsrDA(sqlAll);
            DataSet ds = new DataSet();
            myDA.Fill(ds, "users");

            return ds;
        }

        public DataTable GetComboxDataSource()
        {
            DataSet ds = GetUsrDS();
            DataTable tab = ds.Tables["users"];

            return tab;
        }

        public void UpdateInfo(int cid, string password, bool newlogin)
        {
            DataSet ds = GetUsrDS();
            ds.Tables["users"].Select("id=" + cid)[0]["password"] = password;
            ds.Tables["users"].Select("id=" + cid)[0]["newlogin"] = newlogin;
            myDA.Update(ds, "users");
        }
    }
}
