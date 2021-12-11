using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.BLL;


namespace Hi_Tech_Order_Management_System.DAL
{
    public static class UserDB
    {
        public static void SaveRecords(User usr)
        {
            SqlConnection connDB = new SqlConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO USERS" + "VALUES(" + usr.UserName + "," + usr.Password
                                                                       + usr.EmployeeId + ")";
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();
        }


        public static List<User> GetRecordList()
        {
            List<User> listUsr = new List<User>();

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Users", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User usr;
            while (sqlReader.Read())
            {

                usr = new User();

                
                usr.UserName = Convert.ToInt32(sqlReader["UserName"]);
                usr.Password = sqlReader["Password"].ToString();
                usr.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                listUsr.Add(usr);
            }
            return listUsr;

        }

        public static User GetRecord(int uName)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmdSelect = new SqlCommand();

            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE UserName = " + uName;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User usr = new User();
            if (sqlReader.Read())
            {
                usr.UserName = Convert.ToInt32(sqlReader["UserName"]);
                usr.Password = sqlReader["Password"].ToString();
                usr.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);

            }
            else
            {
                usr = null;
            }

            return usr;
        }
        public static void DeleteRecord(int uName)
        {
            SqlConnection connDb = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Users WHERE UserName = @UserName ";
            cmdDelete.Parameters.AddWithValue("@UserName", uName);
            cmdDelete.Connection = connDb;
            cmdDelete.ExecuteNonQuery();
            connDb.Close();
        }

        public static void UpdateRecord(User usr)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Users SET Password = @Password, EmployeeId = @EmployeeId WHERE UserName = @UserName";
            cmdUpdate.Parameters.AddWithValue("@UserName", usr.UserName);
            cmdUpdate.Parameters.AddWithValue("@Password", usr.Password);
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", usr.EmployeeId);
            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }
    }
}
