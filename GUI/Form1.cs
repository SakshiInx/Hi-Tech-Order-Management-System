using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.Validation;
using Hi_Tech_Order_Management_System.BLL;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            MessageBox.Show(conn.State.ToString(), "Database Connection");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeSaveButton_Click(object sender, EventArgs e)
        {
            string tempId = textBoxEmployeeID.Text.Trim();
            if (!Validator.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBoxEmployeeID.Clear();
                textBoxEmployeeID.Focus();
                return;
            }


            Employee emp = new Employee();
            emp = emp.GetEmployee(Convert.ToInt32(tempId));
            if (emp != null)
            {
                MessageBox.Show("This EmployeeId already exists!", "Duplicate Employee ID");
                textBoxEmployeeID.Clear();
                textBoxEmployeeID.Focus();
                return;
            }

            string tempFname = textBoxFName.Text.Trim();
            if (!Validator.IsValidName(tempFname))
            {
                MessageBox.Show("Invalid First Name", "Error");
                textBoxFName.Clear();
                textBoxFName.Focus();
                return;
            }

            string tempLname = textBoxLName.Text.Trim();
            if (!Validator.IsValidName(tempLname))
            {
                MessageBox.Show("Invalid Last Name", "Error");
                textBoxLName.Clear();
                textBoxLName.Focus();
                return;
            }

            string tempJob = textBoxJobTitle.Text;
            if (!Validator.IsEmpty(tempJob))
            {
                MessageBox.Show("Jobtitle cannot be empty ", "Error");
                textBoxJobTitle.Focus();
                return;
            }
            Employee emp1 = new Employee();
            //Valid data
            emp1.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text);
            emp1.FirstName = textBoxFName.Text.Trim();
            emp1.LastName = textBoxLName.Text.Trim();
            emp1.JobTitle = textBoxJobTitle.Text;
            emp1.SaveEmployee(emp1);
            MessageBox.Show("Employee Info saved successfully", "Confirmation");
        }

        private void EmployeeUpdateButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text);
            emp.FirstName = textBoxFName.Text;
            emp.LastName = textBoxLName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.UpdateEmployee();
            textBoxEmployeeID.Clear();
            textBoxEmployeeID.Focus();
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxJobTitle.Clear();
            MessageBox.Show("This Employee has been updated successfully!", "Confirmation");

        }

        private void EmployeeDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            string tempId = textBoxInfoEmployee.Text.Trim();
            if (!Validator.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBoxInfoEmployee.Clear();
                textBoxInfoEmployee.Focus();
                return;
            }

            // perform search operation by Employee ID
            Employee emp = new Employee();
            emp = emp.GetEmployee(Convert.ToInt32(textBoxInfoEmployee.Text.Trim()));
            if (emp != null)
            {
                textBoxEmployeeID.Text = emp.EmployeeId.ToString();
                textBoxFName.Text = emp.FirstName;
                textBoxLName.Text = emp.LastName;
                textBoxJobTitle.Text = emp.JobTitle;

            }
            else
            {
                MessageBox.Show("Employee not found !", "Invalid Employee ID");
                textBoxInfoEmployee.Clear();
                textBoxInfoEmployee.Focus();
            }
        }

        private void ListEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = new List<Employee>();
            listEmp = emp.GetEmployeeList();
            listViewEmployee.Items.Clear();
            if (listEmp != null)
            {
                foreach (Employee anEmp in listEmp)
                {
                    ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                    item.SubItems.Add(anEmp.FirstName);
                    item.SubItems.Add(anEmp.LastName);
                    item.SubItems.Add(anEmp.JobTitle);
                    listViewEmployee.Items.Add(item);
                }

            }
            else
            {

            }
        }

        private void UserSaveButton_Click(object sender, EventArgs e)
        {
            string tempName = textBoxUserName.Text.Trim();
            if (!Validator.IsValidId(tempName, 4))
            {
                MessageBox.Show("Invalid User Name", "Error");
                textBoxUserName.Clear();
                textBoxUserName.Focus();
                return;
            }


            User usr = new User();
            usr = usr.GetUser(Convert.ToInt32(tempName));
            if (usr != null)
            {
                MessageBox.Show("This User Name already exists!", "Duplicate User Name");
                textBoxUserName.Clear();
                textBoxUserName.Focus();
                return;
            }

            string tempPassword = textBoxPassword.Text.Trim();
            if (!Validator.IsValidName(tempPassword))
            {
                MessageBox.Show("Invalid Password", "Error");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }

            string tempId = textBoxUEMployeeId.Text.Trim();
            if (!Validator.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBoxUEMployeeId.Clear();
                textBoxUEMployeeId.Focus();
                return;
            }

            User usr1 = new User();
            //Valid data
            usr1.UserName = Convert.ToInt32(textBoxUserName.Text);
            usr1.Password = textBoxPassword.Text.Trim();
            usr1.EmployeeId = Convert.ToInt32(textBoxUEMployeeId.Text);
            usr1.SaveUser(usr1);
            MessageBox.Show("User Info saved successfully", "Confirmation");
        }

        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.UserName = Convert.ToInt32(textBoxUserName.Text);
            usr.Password = textBoxPassword.Text;
            usr.EmployeeId = Convert.ToInt32(textBoxUEMployeeId.Text);
            usr.UpdateUser();
            textBoxUserName.Clear();
            textBoxUserName.Focus();
            textBoxPassword.Clear();
            textBoxUEMployeeId.Clear();
            MessageBox.Show("This User has been updated successfully!", "Confirmation");
        }

        private void UserSearchButton_Click(object sender, EventArgs e)
        {
            string tempUName = textBoxInfoUser.Text.Trim();
            if (!Validator.IsValidId(tempUName, 4))
            {
                MessageBox.Show("Invalid User Name", "Error");
                textBoxInfoUser.Clear();
                textBoxInfoUser.Focus();
                return;
            }

            User usr = new User();
            usr = usr.GetUser(Convert.ToInt32(textBoxInfoUser.Text.Trim()));
            if (usr != null)
            {
                textBoxUserName.Text = usr.UserName.ToString();
                textBoxPassword.Text = usr.Password;
                textBoxUEMployeeId.Text = usr.EmployeeId.ToString();

            }
            else
            {
                MessageBox.Show("User not found !", "Invalid User Name");
                textBoxInfoUser.Clear();
                textBoxInfoUser.Focus();
            }
        }

        private void ListUser_Click(object sender, EventArgs e)
        {
            User usr = new User();
            List<User> listUsr = new List<User>();
            listUsr = usr.GetUserList();
            listViewUser.Items.Clear();
            if (listUsr != null)
            {
                foreach (User anUsr in listUsr)
                {
                    ListViewItem item = new ListViewItem(anUsr.UserName.ToString());
                    item.SubItems.Add(anUsr.Password);
                    item.SubItems.Add(anUsr.EmployeeId.ToString());
                    listViewUser.Items.Add(item);
                }

            }
            else
            {

            }
        }
    }
}
