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

namespace Mobile_Shop_Management.AllUserControl
{
    public partial class UserControlCustomer : UserControl
    {
        function fn = new function();
        String query;
       
        public UserControlCustomer()
        {
            InitializeComponent();
        }

       
        private void UserControlCustomer_Load(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            CustomerPurchaseDataGridView.DataSource = ds.Tables[0];
        }

        private void UserControlCustomer_Enter(object sender, EventArgs e)
        {
          
        }

        private void CompanyComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ModelComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        int bid;
        private void CustomerPurchaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerPurchaseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(CustomerPurchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from newMobile where mid=" + bid + "";
            DataSet ds = fn.getData(query);
            Companylabel7.Text = ds.Tables[0].Rows[0][1].ToString();
            Modellabel14.Text = ds.Tables[0].Rows[0][2].ToString();
            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            Internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            Expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            RearCamlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            FrontCamlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            Fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            Pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
           

        }

        private void PurchaseThisItemButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && GenderComboBox1.Text != "" && ContactNumberTextBox2.Text != ""  && AddressTextBox3.Text != ""  && ImeiTextBox4.Text != "")
            {
                String name = NameTextBox.Text;
                String gender = GenderComboBox1.Text;
                Int32 contact = Int32.Parse(ContactNumberTextBox2.Text);
                String address = AddressTextBox3.Text;
                String company = Companylabel7.Text;
                String model = Modellabel14.Text;
                String imei = ImeiTextBox4.Text;
                query = "INSERT INTO customerPurchase ( cname, gender,contact,caddress,company,model,imei) values ('" + name + "' ,'" + gender + "' , " + contact + ",'" + address + "', '" + company + "','" + model + "','" + imei + "')";
                fn.setData(query);
                
                NameTextBox.Clear();
                GenderComboBox1.StartIndex = -1;
                ContactNumberTextBox2.Clear();
                AddressTextBox3.Clear();
                ImeiTextBox4.Clear();
            }
            else 
            {
                MessageBox.Show("Fill All Data. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CustomerPurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            GenderComboBox1.StartIndex = -1;
            ContactNumberTextBox2.Clear();
            AddressTextBox3.Clear();
            ImeiTextBox4.Clear();
           
           
        }
    }
}
