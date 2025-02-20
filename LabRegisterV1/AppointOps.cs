using System;
using System.Data;
using System.Data.SqlClient;

namespace LabRegisterV1
{
    class AppointOps
    {
        string sqlStr = "select * from appointment2 where bookdate=@bookdate";


        public SqlDataAdapter GetAppointDA(string bookdate)
        {
            SqlDataAdapter appDA = new SqlDataAdapter(sqlStr, DBAccess.connStr);
            appDA.SelectCommand.Parameters.Add("@bookdate", SqlDbType.NVarChar, 50);
            appDA.SelectCommand.Parameters["@bookdate"].Value = bookdate;

            //auto construct select, insert, update, delete command in DA
            new SqlCommandBuilder(appDA);
            return appDA;
        }

        public void InitAppointTable(string device, string dat)
        {
            string sql = "select top 1 * from appointment2 where 1=1";
            SqlDataAdapter appointDA = new SqlDataAdapter(sql, DBAccess.connStr);
            new SqlCommandBuilder(appointDA);

            DataSet appointDS = new DataSet();


            appointDA.Fill(appointDS, "appointment2");

            int mon = DateTime.Now.Month;

            int i = 0;
            string order;
            foreach (string hour in DBAccess.hours)
            {
                foreach (string min in DBAccess.mins)
                {
                    order = i.ToString();
                    string[] appoinRow = new string[] { order, device, dat, hour, min, DBAccess.nullname, mon.ToString() };
                    appointDS.Tables["appointment2"].Rows.Add(appoinRow);
                    i++;
                }
            }
            appointDA.Update(appointDS, "appointment2");
        }


    }
}
