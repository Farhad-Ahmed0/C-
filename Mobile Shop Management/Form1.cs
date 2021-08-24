using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlAddEmployee1.Visible = false;
            Dashpanel1.Visible = true;
            addNewPhoneRecordUserControl1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlStock1.Visible = false;
            userControlCustomerRecord1.Visible = false;
            enableDisable(false,false,false);
            userControl1EmployeeRecords1.Visible = false;
            userControlDeletePhoneRecord1.Visible = false;
            Adminpanel1.Visible = false;
           // userControlLogin1.Visible = false;
           
        }

        private void AddNewPhoneButton_Click(object sender, EventArgs e)
        {
            addNewPhoneRecordUserControl1.Visible = true;
            addNewPhoneRecordUserControl1.BringToFront();
            
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomresButton_Click(object sender, EventArgs e)
        {
            userControlCustomer1.Visible = true;
            userControlCustomer1.BringToFront();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            userControlStock1.Visible = true;
            userControlStock1.BringToFront();
        }

        private void CustomersRecordsButton_Click(object sender, EventArgs e)
        {
            userControlCustomerRecord1.Visible = true;
            userControlCustomerRecord1.BringToFront();
        }

        private void userControlStock1_Load(object sender, EventArgs e)
        {

        }

        private void addNewPhoneRecordUserControl1_Load(object sender, EventArgs e)
        {
            
        }
        private void DeletePhoneRecordButton_Click(object sender, EventArgs e)
        {
            userControlDeletePhoneRecord1.Visible = true;
            userControlDeletePhoneRecord1.BringToFront();
            
        }
        

        public void enableDisable(Boolean txtbox , Boolean button1, Boolean button2) 
        {
            PasswordTextBox1.Visible = txtbox;
            VerifyButton1.Visible = button1;
            CancleButton2.Visible = button2;
        }
       

        private void VerifyButton1_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox1.Text == "ADMIN")
            {
                panel2.Enabled = true;
                Adminpanel1.Visible = true;
                enableDisable(false,false,false);
                PasswordTextBox1.Clear();

            }
            else 
            {
                PasswordTextBox1.Clear();
                MessageBox.Show("Wrong Password","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void CancleButton2_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);
            Adminpanel1.Visible = false;

        }
        private void userControlLogin1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void addemployeeButton1_Click(object sender, EventArgs e)
        {
            userControlAddEmployee1.Visible = true;
            userControlAddEmployee1.BringToFront();
        }

        private void EmployeeRecordButton1_Click(object sender, EventArgs e)
        {
            userControl1EmployeeRecords1.Visible = true;
            userControl1EmployeeRecords1.BringToFront();

        }
        private void AdminloginButton1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true,true,true);
        }

        private void Dashpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlLogin1_VisibleChanged_2(object sender, EventArgs e)
        {
          
        }

        private void userControlDeletePhoneRecord1_Load(object sender, EventArgs e)
        {

        }
    }
}
