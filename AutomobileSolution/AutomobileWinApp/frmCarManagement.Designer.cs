namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 15F);
            lbCarID.Location = new Point(39, 46);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(70, 28);
            lbCarID.TabIndex = 0;
            lbCarID.Text = " Car ID";
            lbCarID.Click += label1_Click;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 15F);
            lbCarName.Location = new Point(39, 104);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(103, 28);
            lbCarName.TabIndex = 1;
            lbCarName.Text = " Car Name";
            lbCarName.Click += label1_Click_1;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 15F);
            lbManufacturer.Location = new Point(39, 162);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(129, 28);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 15F);
            lbPrice.Location = new Point(399, 46);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(54, 28);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            lbPrice.Click += label3_Click;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 15F);
            lbReleaseYear.Location = new Point(399, 104);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(117, 28);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(174, 54);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(183, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(174, 112);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(183, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(174, 170);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(183, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(517, 54);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(172, 23);
            txtPrice.TabIndex = 8;
            txtPrice.TextChanged += textBox4_TextChanged;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(517, 112);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(172, 23);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.TextChanged += textBox5_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(105, 220);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 43);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F);
            btnNew.Location = new Point(343, 220);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 43);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(554, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 43);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(-2, 269);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(802, 150);
            dgvCarList.TabIndex = 13;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private FileSystemWatcher fileSystemWatcher1;
    }
}