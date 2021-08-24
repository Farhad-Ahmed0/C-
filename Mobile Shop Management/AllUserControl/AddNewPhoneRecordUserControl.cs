using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Mobile_Shop_Management.AllUserControl
{
    public partial class AddNewPhoneRecordUserControl : UserControl
    {
        function fn = new function();
        String query;
        public AddNewPhoneRecordUserControl()
        {
            InitializeComponent();
        }

        private void RamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CompanyTextBox.Text != "" && ModelNameTextBox.Text != "" && RamComboBox.Text != "" && InternalStorageComboBox.Text != "" && ExpandableMemoryComboBox.Text != "" && DisplayComboBox.Text != "" && RearCameraComboBox.Text != "" && FrontCameraComboBox.Text != "" && FingerPrintSensorComboBox.Text != "" && SIMTypeComboBox.Text != "" && NetworkTypeComboBox.Text != "")
            {
                
                String Company = CompanyTextBox.Text;
                String Model = ModelNameTextBox.Text;
                String Ram = RamComboBox.Text;
                String Internal = InternalStorageComboBox.Text;
                String Expandable = ExpandableMemoryComboBox.Text;
                String Display = DisplayComboBox.Text;
                String Rear = RearCameraComboBox.Text;
                String Front = FrontCameraComboBox.Text;
                String Finger = FingerPrintSensorComboBox.Text;
                String Sim = SIMTypeComboBox.Text;
                String Network = NetworkTypeComboBox.Text;
                Int32 Price = Int32.Parse(PriceTextBox.Text);

                query = "INSERT INTO newMobile(cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) VALUES ('" + Company + "','" + Model + "','" + Ram + "','" + Internal + "','" + Expandable + "','" + Display + "','" + Rear + "','" + Front + "','" + Finger + "','" + Sim + "','" + Network + "'," + Price + ")";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CompanyTextBox.Clear();
            ModelNameTextBox.Clear();
            RamComboBox.StartIndex = -1;
            InternalStorageComboBox.StartIndex = -1;
            ExpandableMemoryComboBox.StartIndex = -1;
            DisplayComboBox.StartIndex = -1;
            RearCameraComboBox.StartIndex = -1;
            FrontCameraComboBox.StartIndex = -1;
            FingerPrintSensorComboBox.StartIndex = -1;
            SIMTypeComboBox.StartIndex = -1;
            NetworkTypeComboBox.StartIndex = -1;
            PriceTextBox.Clear();
        }

        private void AddNewPhoneRecordUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
