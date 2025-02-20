using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLocker
{
    public static class Passwd
    {
        static public int getPwd()
        {
            double pwdNum = Math.Log10(2 + 4 + 22+75);
            int pwd = (int)Math.Round(pwdNum * 100000, 0);

            return pwd;
        }

        //month num
        static private int getCurrentMonNum()
        {
           return DateTime.Now.Month;
        }

        //week num
        static private int getCurrentWeekNum()
        {
            return (int)DateTime.Now.DayOfWeek;
        }

        //Day num
        static private int getCurrentDayNum()
        {
            return DateTime.Now.Day;
        }

        static private int getSumNum()
        {
            return getCurrentMonNum() + getCurrentWeekNum()+ getCurrentDayNum();
        }
        
    }
}
