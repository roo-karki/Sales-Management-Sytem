namespace sales_management_sytem_c
{
    partial class productDetails
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPackageSize = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblsupplierID = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboSupplierID = new System.Windows.Forms.ComboBox();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.lblSerach = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPackageSize = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.lblDateOfSales = new System.Windows.Forms.Label();
            this.dtSales = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(88, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(122, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageSize.Location = new System.Drawing.Point(88, 114);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(118, 20);
            this.lblPackageSize.TabIndex = 1;
            this.lblPackageSize.Text = "Package Size";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(88, 235);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(87, 20);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblsupplierID
            // 
            this.lblsupplierID.AutoSize = true;
            this.lblsupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierID.Location = new System.Drawing.Point(88, 305);
            this.lblsupplierID.Name = "lblsupplierID";
            this.lblsupplierID.Size = new System.Drawing.Size(91, 20);
            this.lblsupplierID.TabIndex = 3;
            this.lblsupplierID.Text = "supplierID";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(289, 41);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(152, 26);
            this.textProductName.TabIndex = 4;
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(289, 232);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.Size = new System.Drawing.Size(152, 26);
            this.textUnitPrice.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(50, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(331, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(487, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 41);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboSupplierID
            // 
            this.cboSupplierID.FormattingEnabled = true;
            this.cboSupplierID.Items.AddRange(new object[] {
            "supplierName"});
            this.cboSupplierID.Location = new System.Drawing.Point(289, 297);
            this.cboSupplierID.Name = "cboSupplierID";
            this.cboSupplierID.Size = new System.Drawing.Size(152, 28);
            this.cboSupplierID.TabIndex = 12;
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(487, 67);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.RowTemplate.Height = 28;
            this.gvProduct.Size = new System.Drawing.Size(531, 258);
            this.gvProduct.TabIndex = 13;
            this.gvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProduct_RowHeaderMouseClick);
            // 
            // lblSerach
            // 
            this.lblSerach.AutoSize = true;
            this.lblSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerach.Location = new System.Drawing.Point(825, 24);
            this.lblSerach.Name = "lblSerach";
            this.lblSerach.Size = new System.Drawing.Size(66, 20);
            this.lblSerach.TabIndex = 14;
            this.lblSerach.Text = "Search";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(920, 21);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(132, 26);
            this.textSearch.TabIndex = 15;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(203, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "sellingPrice";
            // 
            // textPackageSize
            // 
            this.textPackageSize.Location = new System.Drawing.Point(289, 111);
            this.textPackageSize.Name = "textPackageSize";
            this.textPackageSize.Size = new System.Drawing.Size(152, 26);
            this.textPackageSize.TabIndex = 5;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(289, 172);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(152, 26);
            this.txtSellingPrice.TabIndex = 18;
            // 
            // lblDateOfSales
            // 
            this.lblDateOfSales.AutoSize = true;
            this.lblDateOfSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfSales.Location = new System.Drawing.Point(88, 355);
            this.lblDateOfSales.Name = "lblDateOfSales";
            this.lblDateOfSales.Size = new System.Drawing.Size(122, 20);
            this.lblDateOfSales.TabIndex = 19;
            this.lblDateOfSales.Text = "Date Of Sales";
            // 
            // dtSales
            // 
            this.dtSales.Location = new System.Drawing.Point(289, 355);
            this.dtSales.Name = "dtSales";
            this.dtSales.Size = new System.Drawing.Size(268, 26);
            this.dtSales.TabIndex = 20;
            // 
            // productDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 548);
            this.Controls.Add(this.dtSales);
            this.Controls.Add(this.lblDateOfSales);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.lblSerach);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.cboSupplierID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textUnitPrice);
            this.Controls.Add(this.textPackageSize);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.lblsupplierID);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblPackageSize);
            this.Controls.Add(this.lblProductName);
            this.Name = "productDetails";
            this.Text = "productDetails";
            this.Load += new System.EventHandler(this.productDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPackageSize;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblsupplierID;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.Button btnSave;
       
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboSupplierID;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Label lblSerach;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPackageSize;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label lblDateOfSales;
        private System.Windows.Forms.DateTimePicker dtSales;
    }
}