using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;


namespace LabLocker
{
    static class DBAccess
    {
        public static bool loginStatus = false;
        public static bool forceQuit = false;
        //global values
        public static string currentuseranme = "";
        public static string nullname = "";
        public static bool IsInitialized = false;
        public static string connStr = getConnStrDynamic();
        //public static string connStr = @"Data Source=192.168.1.100\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";
        //public static string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";
        //Properties.Settings.Default.labmgmtConnectionString;

        public static string[] hours = { "0:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
        public static string[] mins = { "00:00-09:59", "10:00-19:59", "20:00-29:59", "30:00-39:59", "40:00-49:59", "50:00-59:59" };

        static SqlConnection myConn;



        private static SqlConnection GetConn()
        {
            Debug.WriteLine(Properties.Settings.Default.labmgmtConnectionString);
            if (myConn == null)
            {
                myConn = new SqlConnection(connStr);
            }

            return myConn;
        }

        internal static SqlDataAdapter GetAppointment2DA(string dat)
        {
            AppointOps appointment = new AppointOps();
            SqlDataAdapter da = appointment.GetAppointDA(dat);

            return da;
        }

        //get the server IP, due to the network enviroment changed in the future.
        private static string getIpAddrByConf()
        {
            FileStream fs = new FileStream(@"c:\conf\App.txt", FileMode.Open);
            StreamReader sR = new StreamReader(fs);
            string ipAddr = sR.ReadLine();

            sR.Close();
            fs.Close();

            return ipAddr;
        }

        //get the connection string by IP
        private static string getConnStrByIP(string ipStr)
        {
            string ipConnStr = $"Data Source={ipStr}\\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";

            return ipConnStr;
        }

        //get the connection string by method, instead of string
        private static string getConnStrDynamic()
        {
            string ipAddr = getIpAddrByConf();
            string connStr = getConnStrByIP(ipAddr);
            return connStr;
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
