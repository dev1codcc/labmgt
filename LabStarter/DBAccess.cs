using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace LabStarter
{
    static class DBAccess
    {

        //global values
        //public static string connStr = Properties.Settings.Default.connStrHome;
        public static string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";
        public static bool LoginStatus = false;

        static SqlConnection myConn;



        private static SqlConnection GetConn()
        {
            Debug.WriteLine(connStr);
            if (myConn == null)
            {
                myConn = new SqlConnection(connStr);
            }

            return myConn;
        }

        public static bool CheckConnStatus()
        {
            bool state = false;
            SqlConnection conn = new SqlConnection(connStr);

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    state = true;
                }
                else
                {
                    state = false;
                }

                return state;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                state = false;
                return state;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
