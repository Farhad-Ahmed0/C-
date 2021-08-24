
namespace Mobile_Shop_Management.AllUserControl
{
    partial class UserControl1EmployeeRecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1EmployeeRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerPurchaselabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeSearchTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.EmployeeDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerPurchaselabel
            // 
            this.CustomerPurchaselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPurchaselabel.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPurchaselabel.Image")));
            this.CustomerPurchaselabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerPurchaselabel.Location = new System.Drawing.Point(25, 22);
            this.CustomerPurchaselabel.Name = "CustomerPurchaselabel";
            this.CustomerPurchaselabel.Size = new System.Drawing.Size(243, 55);
            this.CustomerPurchaselabel.TabIndex = 2;
            this.CustomerPurchaselabel.Text = "Employee Records";
            this.CustomerPurchaselabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name";
            // 
            // EmployeeSearchTextBox1
            // 
            this.EmployeeSearchTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeSearchTextBox1.DefaultText = "";
            this.EmployeeSearchTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeSearchTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeSearchTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeSearchTextBox1.DisabledState.Parent = this.EmployeeSearchTextBox1;
            this.EmployeeSearchTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeSearchTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeSearchTextBox1.FocusedState.Parent = this.EmployeeSearchTextBox1;
            this.EmployeeSearchTextBox1.ForeColor = System.Drawing.Color.Black;
            this.EmployeeSearchTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeSearchTextBox1.HoverState.Parent = this.EmployeeSearchTextBox1;
            this.EmployeeSearchTextBox1.Location = new System.Drawing.Point(164, 111);
            this.EmployeeSearchTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeSearchTextBox1.Name = "EmployeeSearchTextBox1";
            this.EmployeeSearchTextBox1.PasswordChar = '\0';
            this.EmployeeSearchTextBox1.PlaceholderText = "";
            this.EmployeeSearchTextBox1.SelectedText = "";
            this.EmployeeSearchTextBox1.ShadowDecoration.Parent = this.EmployeeSearchTextBox1;
            this.EmployeeSearchTextBox1.Size = new System.Drawing.Size(200, 36);
            this.EmployeeSearchTextBox1.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchButton.HoverState.Parent = this.SearchButton;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageRotate = 0F;
            this.SearchButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchButton.Location = new System.Drawing.Point(383, 111);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchButton.PressedState.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(39, 36);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EmployeeDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeDataGridView1.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView1.Location = new System.Drawing.Point(28, 207);
            this.EmployeeDataGridView1.Name = "EmployeeDataGridView1";
            this.EmployeeDataGridView1.RowHeadersVisible = false;
            this.EmployeeDataGridView1.RowHeadersWidth = 51;
            this.EmployeeDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView1.Size = new System.Drawing.Size(1006, 368);
            this.EmployeeDataGridView1.TabIndex = 8;
            this.EmployeeDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.EmployeeDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.EmployeeDataGridView1.ThemeStyle.ReadOnly = false;
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView1_CellClick);
            this.EmployeeDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(768, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 48);
            this.label3.TabIndex = 14;
            this.label3.Text = "Note:\r\nDeleted Data Can not be RESTORED\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(25, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "To Delete Any Record, Click On Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-138, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delete Instruction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(25, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete Instruction";
            // 
            // UserControl1EmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeDataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EmployeeSearchTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerPurchaselabel);
            this.Name = "UserControl1EmployeeRecords";
            this.Size = new System.Drawing.Size(1084, 634);
            this.Load += new System.EventHandler(this.UserControl1EmployeeRecords_Load);
            this.Enter += new System.EventHandler(this.UserControl1EmployeeRecords_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerPurchaselabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeSearchTextBox1;
        private Guna.UI2.WinForms.Guna2ImageButton SearchButton;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
