
namespace Mobile_Shop_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dashpanel1 = new System.Windows.Forms.Panel();
            this.CustomresButton = new Guna.UI2.WinForms.Guna2Button();
            this.StockButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomersRecordsButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeRecordButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.addemployeeButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.CancleButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.VerifyButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddNewPhoneButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeletePhoneRecordButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Adminpanel1 = new System.Windows.Forms.Panel();
            this.AdminloginButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.userControl1EmployeeRecords1 = new Mobile_Shop_Management.AllUserControl.UserControl1EmployeeRecords();
            this.userControlAddEmployee1 = new Mobile_Shop_Management.AllUserControl.UserControlAddEmployee();
            this.userControlDeletePhoneRecord1 = new Mobile_Shop_Management.AllUserControl.UserControlDeletePhoneRecord();
            this.addNewPhoneRecordUserControl1 = new Mobile_Shop_Management.AllUserControl.AddNewPhoneRecordUserControl();
            this.userControlCustomerRecord1 = new Mobile_Shop_Management.AllUserControl.UserControlCustomerRecord();
            this.userControlStock1 = new Mobile_Shop_Management.AllUserControl.UserControlStock();
            this.userControlCustomer1 = new Mobile_Shop_Management.AllUserControl.UserControlCustomer();
            this.Dashpanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Adminpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashpanel1
            // 
            this.Dashpanel1.BackColor = System.Drawing.Color.White;
            this.Dashpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dashpanel1.Controls.Add(this.CustomresButton);
            this.Dashpanel1.Controls.Add(this.StockButton);
            this.Dashpanel1.Controls.Add(this.CustomersRecordsButton);
            this.Dashpanel1.Location = new System.Drawing.Point(12, 12);
            this.Dashpanel1.Name = "Dashpanel1";
            this.Dashpanel1.Size = new System.Drawing.Size(213, 197);
            this.Dashpanel1.TabIndex = 0;
            this.Dashpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Dashpanel1_Paint);
            // 
            // CustomresButton
            // 
            this.CustomresButton.BorderRadius = 24;
            this.CustomresButton.BorderThickness = 2;
            this.CustomresButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomresButton.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.CustomresButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomresButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CustomresButton.CheckedState.Parent = this.CustomresButton;
            this.CustomresButton.CustomImages.Parent = this.CustomresButton;
            this.CustomresButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomresButton.ForeColor = System.Drawing.Color.Black;
            this.CustomresButton.HoverState.Parent = this.CustomresButton;
            this.CustomresButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomresButton.Image")));
            this.CustomresButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomresButton.ImageSize = new System.Drawing.Size(30, 30);
            this.CustomresButton.Location = new System.Drawing.Point(10, 14);
            this.CustomresButton.Name = "CustomresButton";
            this.CustomresButton.ShadowDecoration.Parent = this.CustomresButton;
            this.CustomresButton.Size = new System.Drawing.Size(188, 51);
            this.CustomresButton.TabIndex = 1;
            this.CustomresButton.Text = "Customer";
            this.CustomresButton.Click += new System.EventHandler(this.CustomresButton_Click);
            // 
            // StockButton
            // 
            this.StockButton.BorderRadius = 24;
            this.StockButton.BorderThickness = 2;
            this.StockButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StockButton.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.StockButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.StockButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.StockButton.CheckedState.Parent = this.StockButton;
            this.StockButton.CustomImages.Parent = this.StockButton;
            this.StockButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.StockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockButton.ForeColor = System.Drawing.Color.Black;
            this.StockButton.HoverState.Parent = this.StockButton;
            this.StockButton.Image = ((System.Drawing.Image)(resources.GetObject("StockButton.Image")));
            this.StockButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StockButton.ImageSize = new System.Drawing.Size(30, 30);
            this.StockButton.Location = new System.Drawing.Point(10, 71);
            this.StockButton.Name = "StockButton";
            this.StockButton.ShadowDecoration.Parent = this.StockButton;
            this.StockButton.Size = new System.Drawing.Size(188, 51);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Stock";
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // CustomersRecordsButton
            // 
            this.CustomersRecordsButton.BorderRadius = 24;
            this.CustomersRecordsButton.BorderThickness = 2;
            this.CustomersRecordsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomersRecordsButton.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.CustomersRecordsButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomersRecordsButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CustomersRecordsButton.CheckedState.Parent = this.CustomersRecordsButton;
            this.CustomersRecordsButton.CustomImages.Parent = this.CustomersRecordsButton;
            this.CustomersRecordsButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomersRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersRecordsButton.ForeColor = System.Drawing.Color.Black;
            this.CustomersRecordsButton.HoverState.Parent = this.CustomersRecordsButton;
            this.CustomersRecordsButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomersRecordsButton.Image")));
            this.CustomersRecordsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomersRecordsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.CustomersRecordsButton.Location = new System.Drawing.Point(10, 128);
            this.CustomersRecordsButton.Name = "CustomersRecordsButton";
            this.CustomersRecordsButton.ShadowDecoration.Parent = this.CustomersRecordsButton;
            this.CustomersRecordsButton.Size = new System.Drawing.Size(188, 51);
            this.CustomersRecordsButton.TabIndex = 3;
            this.CustomersRecordsButton.Text = "Customer Records";
            this.CustomersRecordsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CustomersRecordsButton.Click += new System.EventHandler(this.CustomersRecordsButton_Click);
            // 
            // EmployeeRecordButton1
            // 
            this.EmployeeRecordButton1.BorderRadius = 24;
            this.EmployeeRecordButton1.BorderThickness = 2;
            this.EmployeeRecordButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EmployeeRecordButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.EmployeeRecordButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.EmployeeRecordButton1.CheckedState.Parent = this.EmployeeRecordButton1;
            this.EmployeeRecordButton1.CustomImages.Parent = this.EmployeeRecordButton1;
            this.EmployeeRecordButton1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeRecordButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRecordButton1.ForeColor = System.Drawing.Color.Black;
            this.EmployeeRecordButton1.HoverState.Parent = this.EmployeeRecordButton1;
            this.EmployeeRecordButton1.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeRecordButton1.Image")));
            this.EmployeeRecordButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeRecordButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeRecordButton1.Location = new System.Drawing.Point(10, 190);
            this.EmployeeRecordButton1.Name = "EmployeeRecordButton1";
            this.EmployeeRecordButton1.ShadowDecoration.Parent = this.EmployeeRecordButton1;
            this.EmployeeRecordButton1.Size = new System.Drawing.Size(188, 51);
            this.EmployeeRecordButton1.TabIndex = 10;
            this.EmployeeRecordButton1.Text = "Employee Records";
            this.EmployeeRecordButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeRecordButton1.Click += new System.EventHandler(this.EmployeeRecordButton1_Click);
            // 
            // addemployeeButton1
            // 
            this.addemployeeButton1.BorderRadius = 24;
            this.addemployeeButton1.BorderThickness = 2;
            this.addemployeeButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addemployeeButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.addemployeeButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.addemployeeButton1.CheckedState.Parent = this.addemployeeButton1;
            this.addemployeeButton1.CustomImages.Parent = this.addemployeeButton1;
            this.addemployeeButton1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.addemployeeButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployeeButton1.ForeColor = System.Drawing.Color.Black;
            this.addemployeeButton1.HoverState.Parent = this.addemployeeButton1;
            this.addemployeeButton1.Image = ((System.Drawing.Image)(resources.GetObject("addemployeeButton1.Image")));
            this.addemployeeButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addemployeeButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.addemployeeButton1.Location = new System.Drawing.Point(10, 134);
            this.addemployeeButton1.Name = "addemployeeButton1";
            this.addemployeeButton1.ShadowDecoration.Parent = this.addemployeeButton1;
            this.addemployeeButton1.Size = new System.Drawing.Size(188, 50);
            this.addemployeeButton1.TabIndex = 9;
            this.addemployeeButton1.Text = "Add New Employee";
            this.addemployeeButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addemployeeButton1.Click += new System.EventHandler(this.addemployeeButton1_Click);
            // 
            // CancleButton2
            // 
            this.CancleButton2.BorderRadius = 20;
            this.CancleButton2.BorderThickness = 2;
            this.CancleButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CancleButton2.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.CancleButton2.CheckedState.FillColor = System.Drawing.Color.White;
            this.CancleButton2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CancleButton2.CheckedState.Parent = this.CancleButton2;
            this.CancleButton2.CustomImages.Parent = this.CancleButton2;
            this.CancleButton2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancleButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleButton2.ForeColor = System.Drawing.Color.Black;
            this.CancleButton2.HoverState.Parent = this.CancleButton2;
            this.CancleButton2.Location = new System.Drawing.Point(134, 329);
            this.CancleButton2.Name = "CancleButton2";
            this.CancleButton2.ShadowDecoration.Parent = this.CancleButton2;
            this.CancleButton2.Size = new System.Drawing.Size(80, 42);
            this.CancleButton2.TabIndex = 8;
            this.CancleButton2.Text = "Cancle";
            this.CancleButton2.Click += new System.EventHandler(this.CancleButton2_Click);
            // 
            // VerifyButton1
            // 
            this.VerifyButton1.BorderRadius = 20;
            this.VerifyButton1.BorderThickness = 2;
            this.VerifyButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.VerifyButton1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.VerifyButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.VerifyButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.VerifyButton1.CheckedState.Parent = this.VerifyButton1;
            this.VerifyButton1.CustomImages.Parent = this.VerifyButton1;
            this.VerifyButton1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.VerifyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton1.ForeColor = System.Drawing.Color.Black;
            this.VerifyButton1.HoverState.Parent = this.VerifyButton1;
            this.VerifyButton1.Location = new System.Drawing.Point(18, 329);
            this.VerifyButton1.Name = "VerifyButton1";
            this.VerifyButton1.ShadowDecoration.Parent = this.VerifyButton1;
            this.VerifyButton1.Size = new System.Drawing.Size(80, 42);
            this.VerifyButton1.TabIndex = 7;
            this.VerifyButton1.Text = "Verify";
            this.VerifyButton1.Click += new System.EventHandler(this.VerifyButton1_Click);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox1.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextBox1.BorderThickness = 2;
            this.PasswordTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox1.DefaultText = "";
            this.PasswordTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox1.DisabledState.Parent = this.PasswordTextBox1;
            this.PasswordTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox1.FocusedState.Parent = this.PasswordTextBox1;
            this.PasswordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox1.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox1.HoverState.Parent = this.PasswordTextBox1;
            this.PasswordTextBox1.Location = new System.Drawing.Point(18, 285);
            this.PasswordTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.PlaceholderText = "";
            this.PasswordTextBox1.SelectedText = "";
            this.PasswordTextBox1.ShadowDecoration.Parent = this.PasswordTextBox1;
            this.PasswordTextBox1.Size = new System.Drawing.Size(196, 36);
            this.PasswordTextBox1.TabIndex = 6;
            this.PasswordTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddNewPhoneButton
            // 
            this.AddNewPhoneButton.BorderRadius = 24;
            this.AddNewPhoneButton.BorderThickness = 2;
            this.AddNewPhoneButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddNewPhoneButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddNewPhoneButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.AddNewPhoneButton.CheckedState.Parent = this.AddNewPhoneButton;
            this.AddNewPhoneButton.CustomImages.Parent = this.AddNewPhoneButton;
            this.AddNewPhoneButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewPhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewPhoneButton.ForeColor = System.Drawing.Color.Black;
            this.AddNewPhoneButton.HoverState.Parent = this.AddNewPhoneButton;
            this.AddNewPhoneButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNewPhoneButton.Image")));
            this.AddNewPhoneButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewPhoneButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AddNewPhoneButton.Location = new System.Drawing.Point(10, 20);
            this.AddNewPhoneButton.Name = "AddNewPhoneButton";
            this.AddNewPhoneButton.ShadowDecoration.Parent = this.AddNewPhoneButton;
            this.AddNewPhoneButton.Size = new System.Drawing.Size(188, 51);
            this.AddNewPhoneButton.TabIndex = 0;
            this.AddNewPhoneButton.Text = "      Add New Phone";
            this.AddNewPhoneButton.Click += new System.EventHandler(this.AddNewPhoneButton_Click);
            // 
            // DeletePhoneRecordButton
            // 
            this.DeletePhoneRecordButton.BorderRadius = 24;
            this.DeletePhoneRecordButton.BorderThickness = 2;
            this.DeletePhoneRecordButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeletePhoneRecordButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DeletePhoneRecordButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.DeletePhoneRecordButton.CheckedState.Parent = this.DeletePhoneRecordButton;
            this.DeletePhoneRecordButton.CustomImages.Parent = this.DeletePhoneRecordButton;
            this.DeletePhoneRecordButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeletePhoneRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePhoneRecordButton.ForeColor = System.Drawing.Color.Black;
            this.DeletePhoneRecordButton.HoverState.Parent = this.DeletePhoneRecordButton;
            this.DeletePhoneRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletePhoneRecordButton.Image")));
            this.DeletePhoneRecordButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeletePhoneRecordButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DeletePhoneRecordButton.Location = new System.Drawing.Point(10, 77);
            this.DeletePhoneRecordButton.Name = "DeletePhoneRecordButton";
            this.DeletePhoneRecordButton.ShadowDecoration.Parent = this.DeletePhoneRecordButton;
            this.DeletePhoneRecordButton.Size = new System.Drawing.Size(188, 51);
            this.DeletePhoneRecordButton.TabIndex = 4;
            this.DeletePhoneRecordButton.Text = "Delete Phone Record";
            this.DeletePhoneRecordButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeletePhoneRecordButton.Click += new System.EventHandler(this.DeletePhoneRecordButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.userControl1EmployeeRecords1);
            this.panel2.Controls.Add(this.userControlAddEmployee1);
            this.panel2.Controls.Add(this.userControlDeletePhoneRecord1);
            this.panel2.Controls.Add(this.addNewPhoneRecordUserControl1);
            this.panel2.Controls.Add(this.userControlCustomerRecord1);
            this.panel2.Controls.Add(this.userControlStock1);
            this.panel2.Controls.Add(this.userControlCustomer1);
            this.panel2.Location = new System.Drawing.Point(241, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 640);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Adminpanel1
            // 
            this.Adminpanel1.BackColor = System.Drawing.Color.White;
            this.Adminpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Adminpanel1.Controls.Add(this.AddNewPhoneButton);
            this.Adminpanel1.Controls.Add(this.DeletePhoneRecordButton);
            this.Adminpanel1.Controls.Add(this.EmployeeRecordButton1);
            this.Adminpanel1.Controls.Add(this.addemployeeButton1);
            this.Adminpanel1.Location = new System.Drawing.Point(12, 388);
            this.Adminpanel1.Name = "Adminpanel1";
            this.Adminpanel1.Size = new System.Drawing.Size(213, 264);
            this.Adminpanel1.TabIndex = 6;
            // 
            // AdminloginButton1
            // 
            this.AdminloginButton1.BorderRadius = 24;
            this.AdminloginButton1.BorderThickness = 2;
            this.AdminloginButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AdminloginButton1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.AdminloginButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.AdminloginButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.AdminloginButton1.CheckedState.Parent = this.AdminloginButton1;
            this.AdminloginButton1.CustomImages.Parent = this.AdminloginButton1;
            this.AdminloginButton1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminloginButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminloginButton1.ForeColor = System.Drawing.Color.Black;
            this.AdminloginButton1.HoverState.Parent = this.AdminloginButton1;
            this.AdminloginButton1.Image = ((System.Drawing.Image)(resources.GetObject("AdminloginButton1.Image")));
            this.AdminloginButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminloginButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.AdminloginButton1.Location = new System.Drawing.Point(56, 226);
            this.AdminloginButton1.Name = "AdminloginButton1";
            this.AdminloginButton1.ShadowDecoration.Parent = this.AdminloginButton1;
            this.AdminloginButton1.Size = new System.Drawing.Size(131, 51);
            this.AdminloginButton1.TabIndex = 7;
            this.AdminloginButton1.Text = "Admin Login";
            this.AdminloginButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AdminloginButton1.Click += new System.EventHandler(this.AdminloginButton1_Click);
            // 
            // userControl1EmployeeRecords1
            // 
            this.userControl1EmployeeRecords1.BackColor = System.Drawing.Color.White;
            this.userControl1EmployeeRecords1.Location = new System.Drawing.Point(3, 3);
            this.userControl1EmployeeRecords1.Name = "userControl1EmployeeRecords1";
            this.userControl1EmployeeRecords1.Size = new System.Drawing.Size(1084, 634);
            this.userControl1EmployeeRecords1.TabIndex = 6;
            // 
            // userControlAddEmployee1
            // 
            this.userControlAddEmployee1.BackColor = System.Drawing.Color.White;
            this.userControlAddEmployee1.Location = new System.Drawing.Point(3, 3);
            this.userControlAddEmployee1.Name = "userControlAddEmployee1";
            this.userControlAddEmployee1.Size = new System.Drawing.Size(1084, 634);
            this.userControlAddEmployee1.TabIndex = 5;
            // 
            // userControlDeletePhoneRecord1
            // 
            this.userControlDeletePhoneRecord1.BackColor = System.Drawing.Color.White;
            this.userControlDeletePhoneRecord1.Location = new System.Drawing.Point(3, 0);
            this.userControlDeletePhoneRecord1.Name = "userControlDeletePhoneRecord1";
            this.userControlDeletePhoneRecord1.Size = new System.Drawing.Size(1084, 634);
            this.userControlDeletePhoneRecord1.TabIndex = 4;
            // 
            // addNewPhoneRecordUserControl1
            // 
            this.addNewPhoneRecordUserControl1.AutoSize = true;
            this.addNewPhoneRecordUserControl1.BackColor = System.Drawing.Color.White;
            this.addNewPhoneRecordUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addNewPhoneRecordUserControl1.Name = "addNewPhoneRecordUserControl1";
            this.addNewPhoneRecordUserControl1.Size = new System.Drawing.Size(1084, 634);
            this.addNewPhoneRecordUserControl1.TabIndex = 3;
            // 
            // userControlCustomerRecord1
            // 
            this.userControlCustomerRecord1.AutoSize = true;
            this.userControlCustomerRecord1.BackColor = System.Drawing.Color.White;
            this.userControlCustomerRecord1.Location = new System.Drawing.Point(3, 3);
            this.userControlCustomerRecord1.Name = "userControlCustomerRecord1";
            this.userControlCustomerRecord1.Size = new System.Drawing.Size(1084, 634);
            this.userControlCustomerRecord1.TabIndex = 2;
            // 
            // userControlStock1
            // 
            this.userControlStock1.AutoSize = true;
            this.userControlStock1.BackColor = System.Drawing.Color.White;
            this.userControlStock1.Location = new System.Drawing.Point(3, 3);
            this.userControlStock1.Name = "userControlStock1";
            this.userControlStock1.Size = new System.Drawing.Size(1084, 634);
            this.userControlStock1.TabIndex = 1;
            // 
            // userControlCustomer1
            // 
            this.userControlCustomer1.BackColor = System.Drawing.Color.White;
            this.userControlCustomer1.Location = new System.Drawing.Point(3, 3);
            this.userControlCustomer1.Name = "userControlCustomer1";
            this.userControlCustomer1.Size = new System.Drawing.Size(1084, 634);
            this.userControlCustomer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1343, 664);
            this.Controls.Add(this.AdminloginButton1);
            this.Controls.Add(this.VerifyButton1);
            this.Controls.Add(this.Adminpanel1);
            this.Controls.Add(this.CancleButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasswordTextBox1);
            this.Controls.Add(this.Dashpanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Shop Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Dashpanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Adminpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashpanel1;
        private Guna.UI2.WinForms.Guna2Button DeletePhoneRecordButton;
        private Guna.UI2.WinForms.Guna2Button CustomersRecordsButton;
        private Guna.UI2.WinForms.Guna2Button StockButton;
        private Guna.UI2.WinForms.Guna2Button CustomresButton;
        private Guna.UI2.WinForms.Guna2Button AddNewPhoneButton;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox1;
        private Guna.UI2.WinForms.Guna2Button CancleButton2;
        private Guna.UI2.WinForms.Guna2Button VerifyButton1;
        private Guna.UI2.WinForms.Guna2Button addemployeeButton1;
        private Guna.UI2.WinForms.Guna2Button EmployeeRecordButton1;
        private System.Windows.Forms.Panel Adminpanel1;
        private Guna.UI2.WinForms.Guna2Button AdminloginButton1;
        private AllUserControl.UserControl1EmployeeRecords userControl1EmployeeRecords1;
        private AllUserControl.UserControlAddEmployee userControlAddEmployee1;
        private AllUserControl.UserControlDeletePhoneRecord userControlDeletePhoneRecord1;
        private AllUserControl.AddNewPhoneRecordUserControl addNewPhoneRecordUserControl1;
        private AllUserControl.UserControlCustomerRecord userControlCustomerRecord1;
        private AllUserControl.UserControlStock userControlStock1;
        private AllUserControl.UserControlCustomer userControlCustomer1;
    }
}

