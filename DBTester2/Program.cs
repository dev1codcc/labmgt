using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DBTester2
{
    class Program
    {
        static void Main(string[] args)
        {


            //public static string connStr = @"Data Source=192.168.1.100\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";
            string connStr = @"Data Source=192.168.1.100\SQLEXPRESS;Initial Catalog=labmgmt;User ID=sa;Password=jAb@2021#2fG";
            //Console.WriteLine("Hello World!");
            Console.WriteLine(connStr);
            SqlConnection conn = new SqlConnection(connStr);
            
        }
    }
}
