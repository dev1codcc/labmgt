using System;
using System.Data;
using System.Data.SqlClient;

namespace LabRegisterV1
{
    class InitlogOps
    {
        string sql = "select top 1 * from initlog where initdate=@initdate";

        public InitlogOps(string fillDate)
        {
            if (this.IsNullRow(fillDate))
            {
                this.InsertNewDate(fillDate);
            }
        }

        SqlDataAdapter GetInitDA(string fillDate)
        {
            SqlDataAdapter iniDA = new SqlDataAdapter(sql, DBAccess.connStr);
            iniDA.SelectCommand.Parameters.Add("@initdate", SqlDbType.NVarChar, 50);
            iniDA.SelectCommand.Parameters["@initdate"].Value = fillDate;
            new SqlCommandBuilder(iniDA);

            return iniDA;
        }

        void InsertNewDate(string fillDate)
        {
            SqlDataAdapter iniDA = this.GetInitDA(fillDate);
            DataSet iniDS = new DataSet();
            iniDA.Fill(iniDS, "initlog");
            object[] paras = new object[] { fillDate, false };

            iniDS.Tables["initlog"].Rows.Add(paras);
            iniDA.Update(iniDS, "initlog");
            iniDA.Dispose();
        }

        bool IsNullRow(string fillDate)
        {
            SqlDataAdapter iniDA = this.GetInitDA(fillDate);
            DataTable tab = new DataTable("initlog");
            iniDA.Fill(tab);

            if (tab.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFilled(string fillDate)
        {
            SqlDataAdapter iniDA = this.GetInitDA(fillDate);
            DataSet iniDS = new DataSet();
            iniDA.Fill(iniDS, "initlog");
            DataRow[] rows = iniDS.Tables["initlog"].Select("filled=1");

            if (rows.Length == 1)
            {
                Console.WriteLine(rows[0][0] + "--" + rows[0][1] + "--" + rows[0][2]);
                return true;
            }
            else
            {
                return false;
            }
        }



        public void SetFilledFlag(string fillDate, bool flag)
        {
            SqlDataAdapter iniDA = this.GetInitDA(fillDate);
            DataSet iniDS = new DataSet();
            iniDA.Fill(iniDS, "initlog");
            iniDS.Tables["initlog"].Rows[0]["filled"] = flag;
            iniDA.Update(iniDS, "initlog");
        }
    }
}
