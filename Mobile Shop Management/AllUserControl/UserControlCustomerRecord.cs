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
    public partial class UserControlCustomerRecord : UserControl
    {
        function fn = new function();
        String query;
        Boolean flag;
        public UserControlCustomerRecord()
        {
            InitializeComponent();
        }

        private void UserControlCustomerRecord_Enter(object sender, EventArgs e)
        {
            
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchByComboBox.SelectedIndex == 0)
            {
                flag = false;
                ToSetlabel.Text = "Enter Customer Name"; //if user select comboBox index 0 ,Change to Enter Customer name 
            }
            else if (SearchByComboBox.SelectedIndex == 1) 
            {
                flag = true;
                ToSetlabel.Text = "Enter IMEI";  //if user select comboBox index 1 , Change to IMEI
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like '" + SearchTextBox.Text + "%'";
                DataSet ds = fn.getData(query);
                CustomerRecordsDataGridView.DataSource = ds.Tables[0];
            }
            else 
            {
                query = "select * from customerPurchase where imei like '" + SearchTextBox.Text + "%'";
                DataSet ds = fn.getData(query);
                CustomerRecordsDataGridView.DataSource = ds.Tables[0];
            }
        }

        private void CustomerNameSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerRecordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlCustomerRecord_Load(object sender, EventArgs e)
        {
            query = "select * from customerPurchase";
            DataSet ds = fn.getData(query);
            CustomerRecordsDataGridView.DataSource = ds.Tables[0];
        }
    }
}
