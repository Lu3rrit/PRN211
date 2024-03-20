namespace SalesWinApp
{
    partial class frmOrderIU
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
            btnSave = new Button();
            txtOrderID = new TextBox();
            lbShippedDate = new Label();
            lbRequiredDate = new Label();
            lbOrderDate = new Label();
            lbMemberID = new Label();
            lbOrderID = new Label();
            lbFreight = new Label();
            txtFreight = new TextBox();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            txtMemberID = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(288, 268);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 268);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(173, 22);
            txtOrderID.Margin = new Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(219, 23);
            txtOrderID.TabIndex = 20;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(52, 187);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(77, 15);
            lbShippedDate.TabIndex = 18;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(52, 146);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(81, 15);
            lbRequiredDate.TabIndex = 17;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(52, 105);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(61, 15);
            lbOrderDate.TabIndex = 16;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(52, 64);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(63, 15);
            lbMemberID.TabIndex = 15;
            lbMemberID.Text = "MemberID";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(52, 24);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(48, 15);
            lbOrderID.TabIndex = 14;
            lbOrderID.Text = "OrderID";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(52, 227);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(44, 15);
            lbFreight.TabIndex = 18;
            lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(173, 225);
            txtFreight.Margin = new Padding(3, 2, 3, 2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(219, 23);
            txtFreight.TabIndex = 24;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(173, 101);
            dtpOrderDate.Margin = new Padding(3, 2, 3, 2);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(219, 23);
            dtpOrderDate.TabIndex = 28;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(173, 142);
            dtpRequiredDate.Margin = new Padding(3, 2, 3, 2);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(219, 23);
            dtpRequiredDate.TabIndex = 29;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(173, 183);
            dtpShippedDate.Margin = new Padding(3, 2, 3, 2);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(219, 23);
            dtpShippedDate.TabIndex = 30;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(173, 62);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(219, 23);
            txtMemberID.TabIndex = 31;
            // 
            // frmOrderIU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 311);
            Controls.Add(txtMemberID);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(txtOrderID);
            Controls.Add(lbFreight);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrderIU";
            Text = "frmOrderIU";
            Load += frmOrderIU_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtOrderID;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbMemberID;
        private Label lbOrderID;
        private Label lbFreight;
        private TextBox txtFreight;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private TextBox txtMemberID;
    }
}