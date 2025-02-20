using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LabRegisterV1
{
    class UserOps
    {
        //User data is less, initialize to mem
        static string usrSql = "select * from users";
        static SqlDataAdapter usrDA = new SqlDataAdapter(usrSql, DBAccess.connStr);

        static DataSet usrDS = new DataSet();

        static void LoadDS()
        {
            //To avoid fill everytime
            if (usrDS.Tables.Count == 0)
            {
                new SqlCommandBuilder(usrDA);
                usrDA.Fill(usrDS, "users");
            }
        }

        static void FreshDS()
        {
            new SqlCommandBuilder(usrDA);
            usrDA.Fill(usrDS, "users");
        }


        public static bool ExistingUsr(string username, string password)
        {
            LoadDS();

            //Process
            bool result = false;
            string filterStr = "username='" + username + "' and password='" + password + "'";
            if (usrDS.Tables["users"].Select(filterStr).Count() == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        public struct UserProfile
        {
            public static int TimeA = 0;
            public static int TimeB = 0;
            public static bool NewLogin = false;
        }

        public static void LoadUserProfile(string username, string password)
        {
            FreshDS();

            string filterStr = "username='" + username + "' and password='" + password + "'";
            DataRow[] rows = usrDS.Tables["users"].Select(filterStr);
            UserProfile.TimeA = Convert.ToInt32(rows[0]["TotalminutesA"]);
            UserProfile.TimeB = Convert.ToInt32(rows[0]["TotalminutesB"]);
            UserProfile.NewLogin = Convert.ToBoolean(rows[0]["NewLogin"]);
        }

        public static void ChangePassword(string username, string password)
        {
            //Fresh DS
            LoadDS();

            string filterStr = "username='" + username + "'";
            usrDS.Tables["users"].Select(filterStr)[0]["password"] = password;
            usrDS.Tables["users"].Select(filterStr)[0]["newlogin"] = 0;
            usrDA.Update(usrDS, "users");
        }

        public static void ResetTotalminutes()
        {
            UserProfile.TimeA = 0;
            UserProfile.TimeB = 0;
        }

    }
}
