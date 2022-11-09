namespace sales_management_sytem_c
{
    partial class Order
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.DtOrder = new System.Windows.Forms.DateTimePicker();
            this.GrpOrderDetails = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LbProductName = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaleRate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.GrpOrder = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbTotalPurchase = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.GrpSales = new System.Windows.Forms.GroupBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpOrderDetails.SuspendLayout();
            this.GrpOrder.SuspendLayout();
            this.GrpSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "CustomerName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invoice Number:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(202, 105);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(148, 28);
            this.txtInvoiceNumber.TabIndex = 2;
            // 
            // DtOrder
            // 
            this.DtOrder.Location = new System.Drawing.Point(202, 63);
            this.DtOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtOrder.Name = "DtOrder";
            this.DtOrder.Size = new System.Drawing.Size(339, 28);
            this.DtOrder.TabIndex = 3;
            // 
            // GrpOrderDetails
            // 
            this.GrpOrderDetails.Controls.Add(this.txtTotal);
            this.GrpOrderDetails.Controls.Add(this.label13);
            this.GrpOrderDetails.Controls.Add(this.LbProductName);
            this.GrpOrderDetails.Controls.Add(this.label10);
            this.GrpOrderDetails.Controls.Add(this.label9);
            this.GrpOrderDetails.Controls.Add(this.txtProductName);
            this.GrpOrderDetails.Controls.Add(this.label8);
            this.GrpOrderDetails.Controls.Add(this.txtSaleRate);
            this.GrpOrderDetails.Controls.Add(this.txtQuantity);
            this.GrpOrderDetails.Location = new System.Drawing.Point(16, 162);
            this.GrpOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpOrderDetails.Name = "GrpOrderDetails";
            this.GrpOrderDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpOrderDetails.Size = new System.Drawing.Size(1155, 234);
            this.GrpOrderDetails.TabIndex = 4;
            this.GrpOrderDetails.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(994, 29);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 28);
            this.txtTotal.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(896, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 22);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total:";
            // 
            // LbProductName
            // 
            this.LbProductName.FormattingEnabled = true;
            this.LbProductName.ItemHeight = 22;
            this.LbProductName.Location = new System.Drawing.Point(23, 79);
            this.LbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LbProductName.Name = "LbProductName";
            this.LbProductName.Size = new System.Drawing.Size(178, 136);
            this.LbProductName.TabIndex = 5;
            this.LbProductName.Visible = false;
            this.LbProductName.SelectedIndexChanged += new System.EventHandler(this.LbProductName_SelectedIndexChanged);
            this.LbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LbProductName_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sales Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantity:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(166, 26);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(148, 28);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown_1);
            this.txtProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyUp_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "ProductName:";
            // 
            // txtSaleRate
            // 
            this.txtSaleRate.Location = new System.Drawing.Point(446, 31);
            this.txtSaleRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaleRate.Name = "txtSaleRate";
            this.txtSaleRate.Size = new System.Drawing.Size(148, 28);
            this.txtSaleRate.TabIndex = 2;
            this.txtSaleRate.Enter += new System.EventHandler(this.txtSaleRate_Enter_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(716, 31);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 28);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1184, 177);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(1184, 246);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(112, 35);
            this.BtnRemove.TabIndex = 10;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(904, 55);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(180, 30);
            this.cmbCustomerName.TabIndex = 11;
            // 
            // GrpOrder
            // 
            this.GrpOrder.Controls.Add(this.cmbCustomerName);
            this.GrpOrder.Controls.Add(this.BtnRemove);
            this.GrpOrder.Controls.Add(this.btnAdd);
            this.GrpOrder.Controls.Add(this.GrpOrderDetails);
            this.GrpOrder.Controls.Add(this.DtOrder);
            this.GrpOrder.Controls.Add(this.txtInvoiceNumber);
            this.GrpOrder.Controls.Add(this.label4);
            this.GrpOrder.Controls.Add(this.label3);
            this.GrpOrder.Controls.Add(this.label5);
            this.GrpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpOrder.Location = new System.Drawing.Point(13, 105);
            this.GrpOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpOrder.Name = "GrpOrder";
            this.GrpOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpOrder.Size = new System.Drawing.Size(1322, 425);
            this.GrpOrder.TabIndex = 22;
            this.GrpOrder.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(688, 667);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(583, 564);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // lbTotalPurchase
            // 
            this.lbTotalPurchase.AutoSize = true;
            this.lbTotalPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPurchase.Location = new System.Drawing.Point(684, 564);
            this.lbTotalPurchase.Name = "lbTotalPurchase";
            this.lbTotalPurchase.Size = new System.Drawing.Size(19, 20);
            this.lbTotalPurchase.TabIndex = 18;
            this.lbTotalPurchase.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1184, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GrpSales
            // 
            this.GrpSales.Controls.Add(this.BtnExport);
            this.GrpSales.Controls.Add(this.BtnReset);
            this.GrpSales.Controls.Add(this.BtnEdit);
            this.GrpSales.Controls.Add(this.BtnNew);
            this.GrpSales.Controls.Add(this.BtnPrint);
            this.GrpSales.Controls.Add(this.label1);
            this.GrpSales.Location = new System.Drawing.Point(13, 8);
            this.GrpSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpSales.Name = "GrpSales";
            this.GrpSales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpSales.Size = new System.Drawing.Size(1019, 87);
            this.GrpSales.TabIndex = 23;
            this.GrpSales.TabStop = false;
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(628, 22);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(112, 52);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(750, 22);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(112, 52);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(386, 22);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(112, 52);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(264, 22);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(112, 52);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(507, 22);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(112, 52);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // gvOrder
            // 
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.salesRate,
            this.Quantity,
            this.totalAmount});
            this.gvOrder.Location = new System.Drawing.Point(16, 548);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.RowTemplate.Height = 28;
            this.gvOrder.Size = new System.Drawing.Size(495, 159);
            this.gvOrder.TabIndex = 12;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "ProductName";
            this.productName.Name = "productName";
            // 
            // salesRate
            // 
            this.salesRate.DataPropertyName = "salesRate";
            this.salesRate.HeaderText = "salesRate";
            this.salesRate.Name = "salesRate";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // totalAmount
            // 
            this.totalAmount.DataPropertyName = "totalAmount";
            this.totalAmount.HeaderText = "Total";
            this.totalAmount.Name = "totalAmount";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1452, 716);
            this.Controls.Add(this.GrpSales);
            this.Controls.Add(this.GrpOrder);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lbTotalPurchase);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvOrder);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.GrpOrderDetails.ResumeLayout(false);
            this.GrpOrderDetails.PerformLayout();
            this.GrpOrder.ResumeLayout(false);
            this.GrpOrder.PerformLayout();
            this.GrpSales.ResumeLayout(false);
            this.GrpSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.DateTimePicker DtOrder;
        private System.Windows.Forms.GroupBox GrpOrderDetails;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox LbProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaleRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.GroupBox GrpOrder;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbTotalPurchase;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox GrpSales;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
    }
}