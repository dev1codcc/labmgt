using System.Data;
using System.Data.SqlClient;

namespace LabLocker
{
    class UserOps
    {
        //User data is less, initialize to mem
        static string usrSql = "select * from users";
        static SqlDataAdapter usrDA = new SqlDataAdapter(usrSql, DBAccess.connStr);
        static DataSet usrDS = new DataSet();


        public static bool ExistingUsr(string username, string password)
        {
            usrDA.Fill(usrDS, "users");

            //Process
            bool result = false;
            string filerStr = "username='" + username + "' and password='" + password + "'";
            if (usrDS.Tables["users"].Select(filerStr).Length == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

    }
}
