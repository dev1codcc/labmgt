using System.Data.SqlClient;

namespace LabStarter
{
    class Timedat
    {
        public SqlDataAdapter ReturnTimedatDA()
        {
            string sqlStr = "select * from timedat";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, DBAccess.connStr);

            return da;
        }
    }
}
