using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.DAL;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public Employee()
        {

        }
        Employee(int EmployeeId, string FirstName, string LastName, string JobTitle)
        {
            this.employeeId = EmployeeId;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.jobTitle = JobTitle;


        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }

            set
            {
                jobTitle = value;
            }
        }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecords(emp);
        }

        public Employee GetEmployee(int eId)
        {
            return EmployeeDB.GetRecord(eId);
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeDB.GetRecordList();
        }
        public void DeleteEmployee(int empId)
        {
            EmployeeDB.DeleteRecord(empId);
        }
        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);

        }

        internal void UpdateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
