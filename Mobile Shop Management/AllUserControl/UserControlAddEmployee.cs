using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop_Management.AllUserControl
{
    public partial class UserControlAddEmployee : UserControl
    {  function fn = new function();
        String query;
        public UserControlAddEmployee()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (employeenameTextBox1.Text != "" && employeeGenderComboBox1.Text != "" && empolyeeContactTextBox1.Text != "" && employeeEmailIdTextBox1.Text != "" && employeeAddressTextBox1.Text != "" && positionTextBox1.Text != "" && salaryTextBox1.Text != "")
            {

                String Ename = employeenameTextBox1.Text;
                String Gender = employeeGenderComboBox1.Text;
                Int64 contact = Int64.Parse(empolyeeContactTextBox1.Text);
                String Email = employeeEmailIdTextBox1.Text;
                String Address = employeeAddressTextBox1.Text;
                String Position = positionTextBox1.Text;
                Int64 Salary = Int64.Parse(salaryTextBox1.Text);

                query = "INSERT INTO employee(ename,gender,contact,email,eaddress,position,salary) VALUES ('" +Ename + "','" + Gender + "'," + contact + ",'" + Email + "','" + Address + "','" + Position + "'," + Salary + " )";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            employeenameTextBox1.Clear();
            employeeGenderComboBox1.StartIndex=-1;
            empolyeeContactTextBox1.Clear();
            employeeEmailIdTextBox1.Clear();
            employeeAddressTextBox1.Clear();
            positionTextBox1.Clear();
            salaryTextBox1.Clear();
        }

        private void UserControlAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
