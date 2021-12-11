using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Hi_Tech_Order_Management_System.DAL
{
    public static class UtilityDB
    {


        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = @"server=DESKTOP-02B5PC2\MSSQLSERVER2017; database=HiTechDistributionDB; user=sa; password=1234";
            connDB.Open();
            return connDB;
        }
    }
}
