namespace SalesWinApp
{
    partial class frmOrders
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grpOrder = new GroupBox();
            txtShippedDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtOrderDate = new TextBox();
            txtFreight = new TextBox();
            txtMemberID = new TextBox();
            txtOrderIDLeft = new TextBox();
            dgvOrder = new DataGridView();
            btnDelete = new Button();
            btnViewDetail = new Button();
            btnLoad = new Button();
            lbShippedDate = new Label();
            lbRequiredDate = new Label();
            lbOederDate = new Label();
            lbFreight = new Label();
            lbMemberID = new Label();
            lbOrderIDLeft = new Label();
            grpOrderDetail = new GroupBox();
            btnNew = new Button();
            btnDeleteR = new Button();
            dgvOrderDetail = new DataGridView();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtDiscount = new TextBox();
            txtProductID = new TextBox();
            txtOrderIDRight = new TextBox();
            labQuantity = new Label();
            lbUnitPrice = new Label();
            lbDiscount = new Label();
            lbProductID = new Label();
            lbOrderIDRight = new Label();
            btnClose = new Button();
            btnCreate = new Button();
            grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            grpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(txtShippedDate);
            grpOrder.Controls.Add(txtRequiredDate);
            grpOrder.Controls.Add(txtOrderDate);
            grpOrder.Controls.Add(txtFreight);
            grpOrder.Controls.Add(txtMemberID);
            grpOrder.Controls.Add(txtOrderIDLeft);
            grpOrder.Controls.Add(dgvOrder);
            grpOrder.Controls.Add(btnDelete);
            grpOrder.Controls.Add(btnViewDetail);
            grpOrder.Controls.Add(btnLoad);
            grpOrder.Controls.Add(lbShippedDate);
            grpOrder.Controls.Add(lbRequiredDate);
            grpOrder.Controls.Add(lbOederDate);
            grpOrder.Controls.Add(lbFreight);
            grpOrder.Controls.Add(lbMemberID);
            grpOrder.Controls.Add(lbOrderIDLeft);
            grpOrder.Location = new Point(10, 9);
            grpOrder.Margin = new Padding(3, 2, 3, 2);
            grpOrder.Name = "grpOrder";
            grpOrder.Padding = new Padding(3, 2, 3, 2);
            grpOrder.Size = new Size(440, 337);
            grpOrder.TabIndex = 1;
            grpOrder.TabStop = false;
            grpOrder.Text = "Order";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(294, 85);
            txtShippedDate.Margin = new Padding(3, 2, 3, 2);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(141, 23);
            txtShippedDate.TabIndex = 16;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(294, 53);
            txtRequiredDate.Margin = new Padding(3, 2, 3, 2);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(141, 23);
            txtRequiredDate.TabIndex = 15;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(294, 22);
            txtOrderDate.Margin = new Padding(3, 2, 3, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(141, 23);
            txtOrderDate.TabIndex = 14;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(82, 85);
            txtFreight.Margin = new Padding(3, 2, 3, 2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(110, 23);
            txtFreight.TabIndex = 13;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(82, 53);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(110, 23);
            txtMemberID.TabIndex = 12;
            // 
            // txtOrderIDLeft
            // 
            txtOrderIDLeft.Location = new Point(82, 22);
            txtOrderIDLeft.Margin = new Padding(3, 2, 3, 2);
            txtOrderIDLeft.Name = "txtOrderIDLeft";
            txtOrderIDLeft.Size = new Size(110, 23);
            txtOrderIDLeft.TabIndex = 11;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(5, 146);
            dgvOrder.Margin = new Padding(3, 2, 3, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(430, 185);
            dgvOrder.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(353, 120);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(183, 120);
            btnViewDetail.Margin = new Padding(3, 2, 3, 2);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(82, 22);
            btnViewDetail.TabIndex = 7;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(5, 120);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(197, 87);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(77, 15);
            lbShippedDate.TabIndex = 5;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(197, 56);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(81, 15);
            lbRequiredDate.TabIndex = 4;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbOederDate
            // 
            lbOederDate.AutoSize = true;
            lbOederDate.Location = new Point(197, 25);
            lbOederDate.Name = "lbOederDate";
            lbOederDate.Size = new Size(64, 15);
            lbOederDate.TabIndex = 3;
            lbOederDate.Text = "Order Date";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(5, 87);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(44, 15);
            lbFreight.TabIndex = 2;
            lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(5, 56);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(66, 15);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbOrderIDLeft
            // 
            lbOrderIDLeft.AutoSize = true;
            lbOrderIDLeft.Location = new Point(5, 25);
            lbOrderIDLeft.Name = "lbOrderIDLeft";
            lbOrderIDLeft.Size = new Size(51, 15);
            lbOrderIDLeft.TabIndex = 0;
            lbOrderIDLeft.Text = "Order ID";
            // 
            // grpOrderDetail
            // 
            grpOrderDetail.Controls.Add(btnNew);
            grpOrderDetail.Controls.Add(btnDeleteR);
            grpOrderDetail.Controls.Add(dgvOrderDetail);
            grpOrderDetail.Controls.Add(txtQuantity);
            grpOrderDetail.Controls.Add(txtUnitPrice);
            grpOrderDetail.Controls.Add(txtDiscount);
            grpOrderDetail.Controls.Add(txtProductID);
            grpOrderDetail.Controls.Add(txtOrderIDRight);
            grpOrderDetail.Controls.Add(labQuantity);
            grpOrderDetail.Controls.Add(lbUnitPrice);
            grpOrderDetail.Controls.Add(lbDiscount);
            grpOrderDetail.Controls.Add(lbProductID);
            grpOrderDetail.Controls.Add(lbOrderIDRight);
            grpOrderDetail.Location = new Point(456, 9);
            grpOrderDetail.Margin = new Padding(3, 2, 3, 2);
            grpOrderDetail.Name = "grpOrderDetail";
            grpOrderDetail.Padding = new Padding(3, 2, 3, 2);
            grpOrderDetail.Size = new Size(457, 337);
            grpOrderDetail.TabIndex = 2;
            grpOrderDetail.TabStop = false;
            grpOrderDetail.Text = "Order Detail";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(204, 120);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDeleteR
            // 
            btnDeleteR.Location = new Point(369, 120);
            btnDeleteR.Margin = new Padding(3, 2, 3, 2);
            btnDeleteR.Name = "btnDeleteR";
            btnDeleteR.Size = new Size(82, 22);
            btnDeleteR.TabIndex = 11;
            btnDeleteR.Text = "Delete";
            btnDeleteR.UseVisualStyleBackColor = true;
            btnDeleteR.Click += btnDeleteR_Click;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(5, 146);
            dgvOrderDetail.Margin = new Padding(3, 2, 3, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(446, 185);
            dgvOrderDetail.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(312, 53);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(127, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(312, 22);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(127, 23);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(312, 85);
            txtDiscount.Margin = new Padding(3, 2, 3, 2);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(127, 23);
            txtDiscount.TabIndex = 7;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(93, 53);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(120, 23);
            txtProductID.TabIndex = 6;
            // 
            // txtOrderIDRight
            // 
            txtOrderIDRight.Location = new Point(93, 22);
            txtOrderIDRight.Margin = new Padding(3, 2, 3, 2);
            txtOrderIDRight.Name = "txtOrderIDRight";
            txtOrderIDRight.Size = new Size(120, 23);
            txtOrderIDRight.TabIndex = 5;
            // 
            // labQuantity
            // 
            labQuantity.AutoSize = true;
            labQuantity.Location = new Point(229, 56);
            labQuantity.Name = "labQuantity";
            labQuantity.Size = new Size(53, 15);
            labQuantity.TabIndex = 4;
            labQuantity.Text = "Quantity";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(229, 25);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(229, 87);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(54, 15);
            lbDiscount.TabIndex = 2;
            lbDiscount.Text = "Discount";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(18, 56);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "Product ID";
            // 
            // lbOrderIDRight
            // 
            lbOrderIDRight.AutoSize = true;
            lbOrderIDRight.Location = new Point(18, 25);
            lbOrderIDRight.Name = "lbOrderIDRight";
            lbOrderIDRight.Size = new Size(51, 15);
            lbOrderIDRight.TabIndex = 0;
            lbOrderIDRight.Text = "Order ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(403, 350);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(16, 350);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 380);
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(grpOrderDetail);
            Controls.Add(grpOrder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            grpOrderDetail.ResumeLayout(false);
            grpOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grpOrder;
        private GroupBox grpOrderDetail;
        private DataGridView dgvOrder;
        private Button btnClose;
        private Button btnDelete;
        private Button btnViewDetail;
        private Button btnLoad;
        private Label lbShippedDate;
        private Label lbRequiredDate;
        private Label lbOederDate;
        private Label lbFreight;
        private Label lbMemberID;
        private Label lbOrderIDLeft;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtOrderDate;
        private TextBox txtFreight;
        private TextBox txtMemberID;
        private TextBox txtOrderIDLeft;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtDiscount;
        private TextBox txtProductID;
        private TextBox txtOrderIDRight;
        private Label labQuantity;
        private Label lbUnitPrice;
        private Label lbDiscount;
        private Label lbProductID;
        private Label lbOrderIDRight;
        private DataGridView dgvOrderDetail;
        private Button btnCreate;
        private Button btnNew;
        private Button btnDeleteR;
    }
}