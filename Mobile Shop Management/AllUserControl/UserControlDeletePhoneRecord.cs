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
    public partial class UserControlDeletePhoneRecord : UserControl
    {
        function fn = new function();
        String query;
        Boolean flag;
        public UserControlDeletePhoneRecord()
        {
            InitializeComponent();
        }

        private void UserControlDeletePhoneRecord_Enter(object sender, EventArgs e)
        {
           
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }
        int mid;
        private void DeletePhoneRecordDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeletePhoneRecordDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null) 
            {
                mid = int.Parse(DeletePhoneRecordDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from newMobile where mid ="+mid+"";
            if (MessageBox.Show("Deleting Record of " + mid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.getData(query);
            }
            else 
            {
                MessageBox.Show("Operation Cancled","Back",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void UserControlDeletePhoneRecord_Load(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            DeletePhoneRecordDataGridView1.DataSource = ds.Tables[0];
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
                if (flag == false)
                {
                    query = "select * from newMobile where cname like '" + SearchTextBox.Text + "%'";
                    DataSet ds = fn.getData(query);
                    DeletePhoneRecordDataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    query = "select * from newMobile where imei like '" + SearchTextBox.Text + "%'";
                    DataSet ds = fn.getData(query);
                    DeletePhoneRecordDataGridView1.DataSource = ds.Tables[0];
                }
            
        }

        private void DeletePhoneRecordDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
