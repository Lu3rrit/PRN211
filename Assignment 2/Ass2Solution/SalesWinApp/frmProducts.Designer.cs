namespace SalesWinApp
{
    partial class frmProducts
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
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnRemove = new Button();
            btnAddNew = new Button();
            btnLoad = new Button();
            txtUnitInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            txtCategoryID = new TextBox();
            txtProductID = new TextBox();
            lbUnitInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbProductName = new Label();
            lbCategoryID = new Label();
            lbProductID = new Label();
            btnSearch = new Button();
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 208);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 214);
            dataGridView1.TabIndex = 33;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(306, 427);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(520, 182);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(82, 22);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(315, 182);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 22);
            btnAddNew.TabIndex = 30;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(107, 182);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 29;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(473, 90);
            txtUnitInStock.Margin = new Padding(3, 2, 3, 2);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(196, 23);
            txtUnitInStock.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(473, 53);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(196, 23);
            txtUnitPrice.TabIndex = 27;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(473, 18);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(196, 23);
            txtWeight.TabIndex = 26;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(113, 90);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(196, 23);
            txtProductName.TabIndex = 25;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(113, 53);
            txtCategoryID.Margin = new Padding(3, 2, 3, 2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(196, 23);
            txtCategoryID.TabIndex = 24;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(113, 18);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(196, 23);
            txtProductID.TabIndex = 23;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(345, 92);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(74, 15);
            lbUnitInStock.TabIndex = 22;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(345, 56);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 21;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(345, 20);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 20;
            lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(19, 92);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(84, 15);
            lbProductName.TabIndex = 19;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(19, 56);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(69, 15);
            lbCategoryID.TabIndex = 18;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(19, 20);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 17;
            lbProductID.Text = "Product ID";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(19, 136);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Location = new Point(107, 136);
            cboSearch.Margin = new Padding(3, 2, 3, 2);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(98, 23);
            cboSearch.TabIndex = 35;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(209, 137);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(461, 23);
            txtSearch.TabIndex = 36;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 451);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnAddNew);
            Controls.Add(btnLoad);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProducts";
            Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnRemove;
        private Button btnAddNew;
        private Button btnLoad;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private TextBox txtCategoryID;
        private TextBox txtProductID;
        private Label lbUnitInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbProductName;
        private Label lbCategoryID;
        private Label lbProductID;
        private Button btnSearch;
        private ComboBox cboSearch;
        private TextBox txtSearch;
    }
}