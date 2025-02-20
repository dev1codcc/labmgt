using System;
using System.Data;
using System.Data.SqlClient;

namespace LabRegisterV1
{
    public struct TimeUserProfiles
    {
        public int TimeA;
        public int TimeB;
        public string worDat;
    };

    class timesheet
    {
        public bool TheDayInHolidays(DateTime dat)
        {
            string sqlStr = "select * from timedat where dat=@dat";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, DBAccess.connStr);
            da.SelectCommand.Parameters.Add("@dat", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@dat"].Value = dat.ToShortDateString();
            DataTable tab = new DataTable("timedat");
            da.Fill(tab);
            int i = tab.Rows.Count;

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TheDayIsSat(DateTime dat)
        {
            if (dat.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TheDayIsSun(DateTime dat)
        {
            if (dat.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TimeUserProfiles UpdateMins(DateTime dat, string timecode)
        {
            string sqlStr = "select * from timecode where timecode=@timecode";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, DBAccess.connStr);
            da.SelectCommand.Parameters.Add("@timecode", SqlDbType.NVarChar, 50);
            da.SelectCommand.Parameters["@timecode"].Value = timecode;
            DataTable tab = new DataTable("timecode");
            da.Fill(tab);

            TimeUserProfiles pro = new TimeUserProfiles();

            pro.TimeA = Convert.ToInt32(tab.Rows[0]["timea"]);
            pro.TimeB = Convert.ToInt32(tab.Rows[0]["timeb"]);
            pro.worDat = dat.ToShortDateString();

            return pro;
        }
    }
}
