using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hi_Tech_Order_Management_System.BLL;

namespace Hi_Tech_Order_Management_System.DAL
{
    public static class EmployeeDB
    {
        public static void SaveRecords(Employee emp)
        {
            SqlConnection connDB = new SqlConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO EMPLOYEES" + "VALUES(" + emp.EmployeeId + "," + emp.FirstName
                                                                       + emp.LastName + "," + emp.JobTitle + ")";
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();
        }


        public static List<Employee> GetRecordList()
        {
            List<Employee> listEmp = new List<Employee>();

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {

                emp = new Employee();

                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();

                listEmp.Add(emp);

            }
            return listEmp;

        }

        public static Employee GetRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmdSelect = new SqlCommand();

            cmdSelect.CommandText = "SELECT * FROM Employees " +
                                    "WHERE EmployeeId = " + empId;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp = new Employee();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();

            }
            else
            {
                emp = null;
            }

            return emp;
        }
        public static void DeleteRecord(int EmpId)
        {
            SqlConnection connDb = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId ";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", EmpId);
            cmdDelete.Connection = connDb;
            cmdDelete.ExecuteNonQuery();
            connDb.Close();
        }

        public static void UpdateRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, JobTitle = @JobTitle WHERE EmployeeId = @EmployeeId";
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }
    }
}
