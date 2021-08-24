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
    public partial class UserControlStock : UserControl
    {
        function fn = new function();
        String query;
        
        public UserControlStock()
        {
            InitializeComponent();
        }

        private void UserControlStock_Enter(object sender, EventArgs e)
        {
            
        }
        int mid;
        private void StockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null) 
            {
                mid = int.Parse(StockDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from newMobile where mid="+mid+"";
            DataSet ds = fn.getData(query);
            Companylabel7.Text = ds.Tables[0].Rows[0][1].ToString();
            ModelNamelabel8.Text = ds.Tables[0].Rows[0][2].ToString();
            Ramlabel9.Text = ds.Tables[0].Rows[0][3].ToString();
            InternalStroagelabel10.Text = ds.Tables[0].Rows[0][4].ToString();
            ExpandableMemorylabel11.Text = ds.Tables[0].Rows[0][5].ToString();
            Displaylabel12.Text = ds.Tables[0].Rows[0][6].ToString();
            RearCameralabel18.Text = ds.Tables[0].Rows[0][7].ToString();
            FrontCameralabel17.Text = ds.Tables[0].Rows[0][8].ToString();
            FingerprintSensorlabel16.Text = ds.Tables[0].Rows[0][9].ToString();
            Simtypelabel15.Text = ds.Tables[0].Rows[0][10].ToString();
            NetworkTypelabel14.Text = ds.Tables[0].Rows[0][11].ToString();
            Pricelabel13.Text = ds.Tables[0].Rows[0][12].ToString();

        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            StockDataGridView.DataSource = ds.Tables[0];
        }

        private void StockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RearCameralabel18_Click(object sender, EventArgs e)
        {

        }
    }
}
