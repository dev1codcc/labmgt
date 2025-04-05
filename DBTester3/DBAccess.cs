using System.Data.SqlClient;
using System.IO;

namespace DBTester3
{
    class DBAccess
    {

        public static SqlConnection myConn;
        public static string myConnStr;

        public static string GetLocalConnStr()
        {
            return $"Server=localhost\\SQLEXPRESS;Database=labmgmt;Integrated Security=True;";
        }

        public static string getIPConnStr(string ipStr)
        {
            string ipConnStr = $"Data Source={ipStr}\\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";

            return ipConnStr;
        }

        public static string getIpAddr()
        {
            FileStream fs = new FileStream(@"c:\conf\App.txt", FileMode.Open);
            StreamReader sR = new StreamReader(fs);
            string ipAddr = sR.ReadLine();

            sR.Close();
            fs.Close();

            return ipAddr;
        }

        public static void SetupConn(string connStr)
        {
            if (myConn != null)
            {
                myConn.Close();
            }

            myConn = null;

            myConnStr = connStr;
            myConn = new SqlConnection(myConnStr);


        }



    }

}
