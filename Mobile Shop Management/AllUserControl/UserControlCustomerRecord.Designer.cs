
namespace Mobile_Shop_Management.AllUserControl
{
    partial class UserControlCustomerRecord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCustomerRecord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerPurchaselabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ToSetlabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CustomerRecordsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerPurchaselabel
            // 
            this.CustomerPurchaselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPurchaselabel.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPurchaselabel.Image")));
            this.CustomerPurchaselabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerPurchaselabel.Location = new System.Drawing.Point(39, 16);
            this.CustomerPurchaselabel.Name = "CustomerPurchaselabel";
            this.CustomerPurchaselabel.Size = new System.Drawing.Size(233, 55);
            this.CustomerPurchaselabel.TabIndex = 1;
            this.CustomerPurchaselabel.Text = "Customer Records";
            this.CustomerPurchaselabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By";
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchByComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchByComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchByComboBox.FocusedState.Parent = this.SearchByComboBox;
            this.SearchByComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SearchByComboBox.ForeColor = System.Drawing.Color.Black;
            this.SearchByComboBox.HoverState.Parent = this.SearchByComboBox;
            this.SearchByComboBox.ItemHeight = 30;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "Customer Name",
            "IMEI"});
            this.SearchByComboBox.ItemsAppearance.Parent = this.SearchByComboBox;
            this.SearchByComboBox.Location = new System.Drawing.Point(230, 101);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.ShadowDecoration.Parent = this.SearchByComboBox;
            this.SearchByComboBox.Size = new System.Drawing.Size(251, 36);
            this.SearchByComboBox.TabIndex = 3;
            this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByComboBox_SelectedIndexChanged);
            // 
            // ToSetlabel
            // 
            this.ToSetlabel.AutoSize = true;
            this.ToSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToSetlabel.Location = new System.Drawing.Point(227, 163);
            this.ToSetlabel.Name = "ToSetlabel";
            this.ToSetlabel.Size = new System.Drawing.Size(105, 16);
            this.ToSetlabel.TabIndex = 4;
            this.ToSetlabel.Text = "Customer Name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.Parent = this.SearchTextBox;
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.Parent = this.SearchTextBox;
            this.SearchTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.HoverState.Parent = this.SearchTextBox;
            this.SearchTextBox.Location = new System.Drawing.Point(230, 184);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(251, 36);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.CustomerNameSearchTextBox_TextChanged);
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
            this.SearchButton.Location = new System.Drawing.Point(487, 184);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchButton.PressedState.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(39, 37);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerRecordsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerRecordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerRecordsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerRecordsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerRecordsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerRecordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerRecordsDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerRecordsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerRecordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerRecordsDataGridView.EnableHeadersVisualStyles = false;
            this.CustomerRecordsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerRecordsDataGridView.Location = new System.Drawing.Point(43, 292);
            this.CustomerRecordsDataGridView.Name = "CustomerRecordsDataGridView";
            this.CustomerRecordsDataGridView.RowHeadersVisible = false;
            this.CustomerRecordsDataGridView.RowHeadersWidth = 62;
            this.CustomerRecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerRecordsDataGridView.Size = new System.Drawing.Size(1020, 282);
            this.CustomerRecordsDataGridView.TabIndex = 7;
            this.CustomerRecordsDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CustomerRecordsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerRecordsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerRecordsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerRecordsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerRecordsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerRecordsDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.CustomerRecordsDataGridView.ThemeStyle.ReadOnly = false;
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerRecordsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerRecordsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerRecordsDataGridView_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UserControlCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CustomerRecordsDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ToSetlabel);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerPurchaselabel);
            this.Name = "UserControlCustomerRecord";
            this.Size = new System.Drawing.Size(1084, 634);
            this.Load += new System.EventHandler(this.UserControlCustomerRecord_Load);
            this.Enter += new System.EventHandler(this.UserControlCustomerRecord_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerPurchaselabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox SearchByComboBox;
        private System.Windows.Forms.Label ToSetlabel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton SearchButton;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerRecordsDataGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
