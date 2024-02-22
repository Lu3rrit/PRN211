namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            btnClose = new Button();
            lbID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCountry = new Label();
            lbCity = new Label();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtMemberName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            dgvMemberList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            cboSearch = new ComboBox();
            cboFilterCountry = new ComboBox();
            txtSearch = new TextBox();
            btnSort = new Button();
            cboSort = new ComboBox();
            cboFilterCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(308, 415);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(60, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(347, 23);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(87, 15);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(60, 53);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(60, 86);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(347, 86);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(347, 53);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 6;
            lbCity.Text = "City";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(146, 21);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(177, 23);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(146, 51);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(146, 83);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new Point(459, 21);
            txtMemberName.Margin = new Padding(3, 2, 3, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(218, 23);
            txtMemberName.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(459, 51);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(218, 23);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(459, 83);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(218, 23);
            txtCountry.TabIndex = 12;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(10, 236);
            dgvMemberList.Margin = new Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.Size = new Size(679, 175);
            dgvMemberList.TabIndex = 13;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(10, 209);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(308, 209);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(607, 209);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(60, 119);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 22);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(347, 118);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(64, 22);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "ID", "Name" });
            cboSearch.Location = new Point(146, 119);
            cboSearch.Margin = new Padding(3, 2, 3, 2);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(37, 23);
            cboSearch.TabIndex = 19;
            // 
            // cboFilterCountry
            // 
            cboFilterCountry.FormattingEnabled = true;
            cboFilterCountry.Location = new Point(459, 120);
            cboFilterCountry.Margin = new Padding(3, 2, 3, 2);
            cboFilterCountry.Name = "cboFilterCountry";
            cboFilterCountry.Size = new Size(72, 23);
            cboFilterCountry.TabIndex = 20;
            cboFilterCountry.SelectedIndexChanged += cboFilterType_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(188, 119);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(135, 23);
            txtSearch.TabIndex = 21;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(224, 170);
            btnSort.Margin = new Padding(3, 2, 3, 2);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(63, 22);
            btnSort.TabIndex = 22;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "By ID ascending", "By ID descending", "By Name ascending", "By Name descending" });
            cboSort.Location = new Point(293, 169);
            cboSort.Margin = new Padding(3, 2, 3, 2);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(177, 23);
            cboSort.TabIndex = 23;
            cboSort.Text = "--Select--";
            // 
            // cboFilterCity
            // 
            cboFilterCity.Enabled = false;
            cboFilterCity.FormattingEnabled = true;
            cboFilterCity.Location = new Point(537, 120);
            cboFilterCity.Margin = new Padding(3, 2, 3, 2);
            cboFilterCity.Name = "cboFilterCity";
            cboFilterCity.Size = new Size(100, 23);
            cboFilterCity.TabIndex = 24;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 442);
            Controls.Add(cboFilterCity);
            Controls.Add(cboSort);
            Controls.Add(btnSort);
            Controls.Add(txtSearch);
            Controls.Add(cboFilterCountry);
            Controls.Add(cboSearch);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtMemberName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbID);
            Controls.Add(btnClose);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lbID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCountry;
        private Label lbCity;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtMemberName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnFilter;
        private ComboBox cboSearch;
        private ComboBox cboFilterCountry;
        private TextBox txtSearch;
        private Button btnSort;
        private ComboBox cboSort;
        private ComboBox cboFilterCity;
    }
}