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
    public class User
    {
        private int userName;
        private string password;
        private int employeeId;

        public int UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
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

        public void SaveUser(User usr)
        {
            UserDB.SaveRecords(usr);
        }

        public User GetUser(int uName)
        {
            return UserDB.GetRecord(uName);
        }

        public List<User> GetUserList()
        {
            return UserDB.GetRecordList();
        }
        public void UserEmployee(int uName)
        {
            UserDB.DeleteRecord(uName);
        }
        public void UpdateUser(User usr)
        {
            UserDB.UpdateRecord(usr);

        }

        internal void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
