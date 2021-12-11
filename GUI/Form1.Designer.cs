
namespace Hi_Tech_Order_Management_System.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = new System.Windows.Forms.Label();
            this.textBoxInfoEmployee = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.ListEmployee = new System.Windows.Forms.Button();
            this.EmployeeSearchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeDeleteButton = new System.Windows.Forms.Button();
            this.EmployeeUpdateButton = new System.Windows.Forms.Button();
            this.EmployeeSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInfoUser = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ListUser = new System.Windows.Forms.Button();
            this.UserSearchButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.UserDeleteButton = new System.Windows.Forms.Button();
            this.UserUpdateButton = new System.Windows.Forms.Button();
            this.UserSaveButton = new System.Windows.Forms.Button();
            this.textBoxUEMployeeId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.UEmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewEmployee);
            this.groupBox1.Controls.Add(this.info);
            this.groupBox1.Controls.Add(this.textBoxInfoEmployee);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxJobTitle);
            this.groupBox1.Controls.Add(this.textBoxLName);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.textBoxEmployeeID);
            this.groupBox1.Controls.Add(this.ListEmployee);
            this.groupBox1.Controls.Add(this.EmployeeSearchButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.EmployeeDeleteButton);
            this.groupBox1.Controls.Add(this.EmployeeUpdateButton);
            this.groupBox1.Controls.Add(this.EmployeeSaveButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(605, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.FirstName,
            this.LastName,
            this.JobTitle});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(19, 314);
            this.listViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(497, 134);
            this.listViewEmployee.TabIndex = 61;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "EmployeeID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            // 
            // JobTitle
            // 
            this.JobTitle.Text = "JobTitle";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(43, 219);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(93, 17);
            this.info.TabIndex = 69;
            this.info.Text = "Enter the Info";
            // 
            // textBoxInfoEmployee
            // 
            this.textBoxInfoEmployee.Location = new System.Drawing.Point(167, 219);
            this.textBoxInfoEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInfoEmployee.Name = "textBoxInfoEmployee";
            this.textBoxInfoEmployee.Size = new System.Drawing.Size(176, 22);
            this.textBoxInfoEmployee.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EmployeeId",
            "FirstName",
            "LastName",
            "JobTitle"});
            this.comboBox1.Location = new System.Drawing.Point(199, 189);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 67;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(194, 127);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(135, 22);
            this.textBoxJobTitle.TabIndex = 66;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(194, 94);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(135, 22);
            this.textBoxLName.TabIndex = 65;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(194, 56);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(135, 22);
            this.textBoxFName.TabIndex = 64;
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(194, 19);
            this.textBoxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(135, 22);
            this.textBoxEmployeeID.TabIndex = 63;
            // 
            // ListEmployee
            // 
            this.ListEmployee.Location = new System.Drawing.Point(304, 256);
            this.ListEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListEmployee.Name = "ListEmployee";
            this.ListEmployee.Size = new System.Drawing.Size(212, 42);
            this.ListEmployee.TabIndex = 62;
            this.ListEmployee.Text = "List All Employee";
            this.ListEmployee.UseVisualStyleBackColor = true;
            this.ListEmployee.Click += new System.EventHandler(this.ListEmployee_Click);
            // 
            // EmployeeSearchButton
            // 
            this.EmployeeSearchButton.Location = new System.Drawing.Point(46, 259);
            this.EmployeeSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.Size = new System.Drawing.Size(174, 37);
            this.EmployeeSearchButton.TabIndex = 60;
            this.EmployeeSearchButton.Text = "Search";
            this.EmployeeSearchButton.UseVisualStyleBackColor = true;
            this.EmployeeSearchButton.Click += new System.EventHandler(this.EmployeeSearchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Search By";
            // 
            // EmployeeDeleteButton
            // 
            this.EmployeeDeleteButton.Location = new System.Drawing.Point(354, 119);
            this.EmployeeDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDeleteButton.Name = "EmployeeDeleteButton";
            this.EmployeeDeleteButton.Size = new System.Drawing.Size(91, 37);
            this.EmployeeDeleteButton.TabIndex = 58;
            this.EmployeeDeleteButton.Text = "DELETE";
            this.EmployeeDeleteButton.UseVisualStyleBackColor = true;
            this.EmployeeDeleteButton.Click += new System.EventHandler(this.EmployeeDeleteButton_Click);
            // 
            // EmployeeUpdateButton
            // 
            this.EmployeeUpdateButton.Location = new System.Drawing.Point(354, 72);
            this.EmployeeUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeUpdateButton.Name = "EmployeeUpdateButton";
            this.EmployeeUpdateButton.Size = new System.Drawing.Size(91, 38);
            this.EmployeeUpdateButton.TabIndex = 57;
            this.EmployeeUpdateButton.Text = "UPDATE";
            this.EmployeeUpdateButton.UseVisualStyleBackColor = true;
            this.EmployeeUpdateButton.Click += new System.EventHandler(this.EmployeeUpdateButton_Click);
            // 
            // EmployeeSaveButton
            // 
            this.EmployeeSaveButton.Location = new System.Drawing.Point(354, 19);
            this.EmployeeSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeSaveButton.Name = "EmployeeSaveButton";
            this.EmployeeSaveButton.Size = new System.Drawing.Size(91, 49);
            this.EmployeeSaveButton.TabIndex = 56;
            this.EmployeeSaveButton.Text = "SAVE";
            this.EmployeeSaveButton.UseVisualStyleBackColor = true;
            this.EmployeeSaveButton.Click += new System.EventHandler(this.EmployeeSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Job title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewUser);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxInfoUser);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.ListUser);
            this.groupBox2.Controls.Add(this.UserSearchButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UserDeleteButton);
            this.groupBox2.Controls.Add(this.UserUpdateButton);
            this.groupBox2.Controls.Add(this.UserSaveButton);
            this.groupBox2.Controls.Add(this.textBoxUEMployeeId);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Password,
            this.UEmployeeId});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(11, 317);
            this.listViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(497, 134);
            this.listViewUser.TabIndex = 72;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 142;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 135;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Enter the Info";
            // 
            // textBoxInfoUser
            // 
            this.textBoxInfoUser.Location = new System.Drawing.Point(159, 222);
            this.textBoxInfoUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInfoUser.Name = "textBoxInfoUser";
            this.textBoxInfoUser.Size = new System.Drawing.Size(176, 22);
            this.textBoxInfoUser.TabIndex = 75;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "User Name",
            "Password",
            "Employee Id"});
            this.comboBox2.Location = new System.Drawing.Point(191, 192);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 24);
            this.comboBox2.TabIndex = 74;
            // 
            // ListUser
            // 
            this.ListUser.Location = new System.Drawing.Point(296, 259);
            this.ListUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListUser.Name = "ListUser";
            this.ListUser.Size = new System.Drawing.Size(212, 42);
            this.ListUser.TabIndex = 73;
            this.ListUser.Text = "List All Users";
            this.ListUser.UseVisualStyleBackColor = true;
            this.ListUser.Click += new System.EventHandler(this.ListUser_Click);
            // 
            // UserSearchButton
            // 
            this.UserSearchButton.Location = new System.Drawing.Point(38, 262);
            this.UserSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserSearchButton.Name = "UserSearchButton";
            this.UserSearchButton.Size = new System.Drawing.Size(174, 37);
            this.UserSearchButton.TabIndex = 71;
            this.UserSearchButton.Text = "Search";
            this.UserSearchButton.UseVisualStyleBackColor = true;
            this.UserSearchButton.Click += new System.EventHandler(this.UserSearchButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Search By";
            // 
            // UserDeleteButton
            // 
            this.UserDeleteButton.Location = new System.Drawing.Point(349, 135);
            this.UserDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserDeleteButton.Name = "UserDeleteButton";
            this.UserDeleteButton.Size = new System.Drawing.Size(91, 37);
            this.UserDeleteButton.TabIndex = 69;
            this.UserDeleteButton.Text = "DELETE";
            this.UserDeleteButton.UseVisualStyleBackColor = true;
            // 
            // UserUpdateButton
            // 
            this.UserUpdateButton.Location = new System.Drawing.Point(349, 88);
            this.UserUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserUpdateButton.Name = "UserUpdateButton";
            this.UserUpdateButton.Size = new System.Drawing.Size(91, 38);
            this.UserUpdateButton.TabIndex = 68;
            this.UserUpdateButton.Text = "UPDATE";
            this.UserUpdateButton.UseVisualStyleBackColor = true;
            this.UserUpdateButton.Click += new System.EventHandler(this.UserUpdateButton_Click);
            // 
            // UserSaveButton
            // 
            this.UserSaveButton.Location = new System.Drawing.Point(349, 35);
            this.UserSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserSaveButton.Name = "UserSaveButton";
            this.UserSaveButton.Size = new System.Drawing.Size(91, 49);
            this.UserSaveButton.TabIndex = 67;
            this.UserSaveButton.Text = "SAVE";
            this.UserSaveButton.UseVisualStyleBackColor = true;
            this.UserSaveButton.Click += new System.EventHandler(this.UserSaveButton_Click);
            // 
            // textBoxUEMployeeId
            // 
            this.textBoxUEMployeeId.Location = new System.Drawing.Point(153, 106);
            this.textBoxUEMployeeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUEMployeeId.Name = "textBoxUEMployeeId";
            this.textBoxUEMployeeId.Size = new System.Drawing.Size(135, 22);
            this.textBoxUEMployeeId.TabIndex = 66;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(153, 72);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(135, 22);
            this.textBoxPassword.TabIndex = 65;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(153, 35);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(135, 22);
            this.textBoxUserName.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "EmployeeId:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(135, 490);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(134, 36);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "&Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(637, 490);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 36);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UEmployeeId
            // 
            this.UEmployeeId.Text = "Employee ID";
            this.UEmployeeId.Width = 147;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 527);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader JobTitle;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.TextBox textBoxInfoEmployee;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Button ListEmployee;
        private System.Windows.Forms.Button EmployeeSearchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EmployeeDeleteButton;
        private System.Windows.Forms.Button EmployeeUpdateButton;
        private System.Windows.Forms.Button EmployeeSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUEMployeeId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInfoUser;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ListUser;
        private System.Windows.Forms.Button UserSearchButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UserDeleteButton;
        private System.Windows.Forms.Button UserUpdateButton;
        private System.Windows.Forms.Button UserSaveButton;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ColumnHeader UEmployeeId;
    }
}