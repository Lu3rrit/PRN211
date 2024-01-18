namespace AutomobileWinApp;

partial class frmCarDetails
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbCarID = new Label();
        lbCarName = new Label();
        lbManufacture = new Label();
        lbPrice = new Label();
        lbReleaseYear = new Label();
        txtCarID = new TextBox();
        txtCarName = new TextBox();
        cboManufacturer = new ComboBox();
        txtPrice = new MaskedTextBox();
        txtReleaseYear = new MaskedTextBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lbCarID
        // 
        lbCarID.AutoSize = true;
        lbCarID.Location = new Point(37, 24);
        lbCarID.Name = "lbCarID";
        lbCarID.Size = new Size(50, 20);
        lbCarID.TabIndex = 0;
        lbCarID.Text = "Car ID";
        // 
        // lbCarName
        // 
        lbCarName.AutoSize = true;
        lbCarName.Location = new Point(37, 62);
        lbCarName.Name = "lbCarName";
        lbCarName.Size = new Size(75, 20);
        lbCarName.TabIndex = 1;
        lbCarName.Text = "Car Name";
        // 
        // lbManufacture
        // 
        lbManufacture.AutoSize = true;
        lbManufacture.Location = new Point(37, 101);
        lbManufacture.Name = "lbManufacture";
        lbManufacture.Size = new Size(97, 20);
        lbManufacture.TabIndex = 2;
        lbManufacture.Text = "Manufacturer";
        // 
        // lbPrice
        // 
        lbPrice.AutoSize = true;
        lbPrice.Location = new Point(37, 143);
        lbPrice.Name = "lbPrice";
        lbPrice.Size = new Size(41, 20);
        lbPrice.TabIndex = 3;
        lbPrice.Text = "Price";
        // 
        // lbReleaseYear
        // 
        lbReleaseYear.AutoSize = true;
        lbReleaseYear.Location = new Point(37, 180);
        lbReleaseYear.Name = "lbReleaseYear";
        lbReleaseYear.Size = new Size(92, 20);
        lbReleaseYear.TabIndex = 4;
        lbReleaseYear.Text = "Release Year";
        // 
        // txtCarID
        // 
        txtCarID.Location = new Point(140, 21);
        txtCarID.Name = "txtCarID";
        txtCarID.Size = new Size(259, 27);
        txtCarID.TabIndex = 0;
        // 
        // txtCarName
        // 
        txtCarName.Location = new Point(140, 59);
        txtCarName.Name = "txtCarName";
        txtCarName.Size = new Size(259, 27);
        txtCarName.TabIndex = 1;
        // 
        // cboManufacturer
        // 
        cboManufacturer.FormattingEnabled = true;
        cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
        cboManufacturer.Location = new Point(140, 101);
        cboManufacturer.Name = "cboManufacturer";
        cboManufacturer.Size = new Size(259, 28);
        cboManufacturer.TabIndex = 2;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(140, 140);
        txtPrice.Mask = "000000000";
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(259, 27);
        txtPrice.TabIndex = 3;
        txtPrice.Text = "0";
        // 
        // txtReleaseYear
        // 
        txtReleaseYear.Location = new Point(140, 177);
        txtReleaseYear.Mask = "0000";
        txtReleaseYear.Name = "txtReleaseYear";
        txtReleaseYear.Size = new Size(259, 27);
        txtReleaseYear.TabIndex = 4;
        txtReleaseYear.Text = "0";
        // 
        // btnSave
        // 
        btnSave.DialogResult = DialogResult.OK;
        btnSave.Location = new Point(140, 237);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 10;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(305, 237);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 11;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // frmCarDetails
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(txtReleaseYear);
        Controls.Add(txtPrice);
        Controls.Add(cboManufacturer);
        Controls.Add(txtCarName);
        Controls.Add(txtCarID);
        Controls.Add(lbReleaseYear);
        Controls.Add(lbPrice);
        Controls.Add(lbManufacture);
        Controls.Add(lbCarName);
        Controls.Add(lbCarID);
        Name = "frmCarDetails";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "frmCarDetails";
        Load += frmCarDetails_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbCarID;
    private Label lbCarName;
    private Label lbManufacture;
    private Label lbPrice;
    private Label lbReleaseYear;
    private TextBox txtCarID;
    private TextBox txtCarName;
    private ComboBox cboManufacturer;
    private MaskedTextBox txtPrice;
    private MaskedTextBox txtReleaseYear;
    private Button btnSave;
    private Button btnCancel;
}
