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
    public partial class UserControl1EmployeeRecords : UserControl
    {
        function fn = new function();
        String query;
        public UserControl1EmployeeRecords()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query = "select * from employee where ename like '" + EmployeeSearchTextBox1.Text + "%'";
            DataSet ds = fn.getData(query);
            EmployeeDataGridView1.DataSource = ds.Tables[0];
        }

        private void UserControl1EmployeeRecords_Enter(object sender, EventArgs e)
        {
            
        }
        int eid;
        private void EmployeeDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                eid = int.Parse(EmployeeDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from employee where eid =" + eid + "";
            if (MessageBox.Show("Deleting Record of " + eid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.getData(query);
            }
            else
            {
                MessageBox.Show("Operation Cancled", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmployeeDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl1EmployeeRecords_Load(object sender, EventArgs e)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            EmployeeDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
