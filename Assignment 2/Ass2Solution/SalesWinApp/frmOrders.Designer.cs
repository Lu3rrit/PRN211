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
            grpOrderDetail = new GroupBox();
            lbOrderIDLeft = new Label();
            lbMemberID = new Label();
            lbFreight = new Label();
            lbOederDate = new Label();
            lbRequiredDate = new Label();
            lbShippedDate = new Label();
            btnLoad = new Button();
            btnViewDetail = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvOrder = new DataGridView();
            txtOrderIDLeft = new TextBox();
            txtMemberID = new TextBox();
            txtFreight = new TextBox();
            txtOrderDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtShippedDate = new TextBox();
            lbOrderIDRight = new Label();
            lbProductID = new Label();
            lbDiscount = new Label();
            lbUnitPrice = new Label();
            labQuantity = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dgvOrderDetail = new DataGridView();
            btnCreate = new Button();
            grpOrder.SuspendLayout();
            grpOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
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
            grpOrder.Location = new Point(12, 12);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(503, 449);
            grpOrder.TabIndex = 1;
            grpOrder.TabStop = false;
            grpOrder.Text = "Order";
            // 
            // grpOrderDetail
            // 
            grpOrderDetail.Controls.Add(dgvOrderDetail);
            grpOrderDetail.Controls.Add(textBox5);
            grpOrderDetail.Controls.Add(textBox4);
            grpOrderDetail.Controls.Add(textBox3);
            grpOrderDetail.Controls.Add(textBox2);
            grpOrderDetail.Controls.Add(textBox1);
            grpOrderDetail.Controls.Add(labQuantity);
            grpOrderDetail.Controls.Add(lbUnitPrice);
            grpOrderDetail.Controls.Add(lbDiscount);
            grpOrderDetail.Controls.Add(lbProductID);
            grpOrderDetail.Controls.Add(lbOrderIDRight);
            grpOrderDetail.Location = new Point(521, 12);
            grpOrderDetail.Name = "grpOrderDetail";
            grpOrderDetail.Size = new Size(522, 449);
            grpOrderDetail.TabIndex = 2;
            grpOrderDetail.TabStop = false;
            grpOrderDetail.Text = "Order Detail";
            // 
            // lbOrderIDLeft
            // 
            lbOrderIDLeft.AutoSize = true;
            lbOrderIDLeft.Location = new Point(6, 33);
            lbOrderIDLeft.Name = "lbOrderIDLeft";
            lbOrderIDLeft.Size = new Size(66, 20);
            lbOrderIDLeft.TabIndex = 0;
            lbOrderIDLeft.Text = "Order ID";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(6, 74);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(6, 116);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(55, 20);
            lbFreight.TabIndex = 2;
            lbFreight.Text = "Freight";
            // 
            // lbOederDate
            // 
            lbOederDate.AutoSize = true;
            lbOederDate.Location = new Point(225, 33);
            lbOederDate.Name = "lbOederDate";
            lbOederDate.Size = new Size(83, 20);
            lbOederDate.TabIndex = 3;
            lbOederDate.Text = "Order Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(225, 74);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(105, 20);
            lbRequiredDate.TabIndex = 4;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(225, 116);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(100, 20);
            lbShippedDate.TabIndex = 5;
            lbShippedDate.Text = "Shipped Date";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(6, 160);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(209, 160);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(94, 29);
            btnViewDetail.TabIndex = 7;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(461, 467);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(6, 195);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(491, 247);
            dgvOrder.TabIndex = 10;
            // 
            // txtOrderIDLeft
            // 
            txtOrderIDLeft.Location = new Point(94, 30);
            txtOrderIDLeft.Name = "txtOrderIDLeft";
            txtOrderIDLeft.Size = new Size(125, 27);
            txtOrderIDLeft.TabIndex = 11;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(94, 71);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(125, 27);
            txtMemberID.TabIndex = 12;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(94, 113);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(125, 27);
            txtFreight.TabIndex = 13;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(336, 30);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(161, 27);
            txtOrderDate.TabIndex = 14;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(336, 71);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(161, 27);
            txtRequiredDate.TabIndex = 15;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(336, 113);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(161, 27);
            txtShippedDate.TabIndex = 16;
            // 
            // lbOrderIDRight
            // 
            lbOrderIDRight.AutoSize = true;
            lbOrderIDRight.Location = new Point(21, 33);
            lbOrderIDRight.Name = "lbOrderIDRight";
            lbOrderIDRight.Size = new Size(66, 20);
            lbOrderIDRight.TabIndex = 0;
            lbOrderIDRight.Text = "Order ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(21, 74);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "Product ID";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(262, 116);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 2;
            lbDiscount.Text = "Discount";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(262, 33);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // labQuantity
            // 
            labQuantity.AutoSize = true;
            labQuantity.Location = new Point(262, 74);
            labQuantity.Name = "labQuantity";
            labQuantity.Size = new Size(65, 20);
            labQuantity.TabIndex = 4;
            labQuantity.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(356, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(356, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(356, 71);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 27);
            textBox5.TabIndex = 9;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(6, 195);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(510, 247);
            dgvOrderDetail.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(18, 467);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 507);
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(grpOrderDetail);
            Controls.Add(grpOrder);
            Name = "frmOrders";
            Text = "frmOrders";
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            grpOrderDetail.ResumeLayout(false);
            grpOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
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
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labQuantity;
        private Label lbUnitPrice;
        private Label lbDiscount;
        private Label lbProductID;
        private Label lbOrderIDRight;
        private DataGridView dgvOrderDetail;
        private Button btnCreate;
    }
}