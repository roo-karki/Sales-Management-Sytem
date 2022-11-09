namespace sales_management_sytem_c
{
    partial class Admin
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
            this.btnRegisteration = new System.Windows.Forms.Button();
            this.btnSupplierDetails = new System.Windows.Forms.Button();
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnSalesCustomerReport = new System.Windows.Forms.Button();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisteration
            // 
            this.btnRegisteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteration.Location = new System.Drawing.Point(114, 36);
            this.btnRegisteration.Name = "btnRegisteration";
            this.btnRegisteration.Size = new System.Drawing.Size(146, 45);
            this.btnRegisteration.TabIndex = 0;
            this.btnRegisteration.Text = "Registeration";
            this.btnRegisteration.UseVisualStyleBackColor = true;
            this.btnRegisteration.Click += new System.EventHandler(this.btnRegisteration_Click);
            // 
            // btnSupplierDetails
            // 
            this.btnSupplierDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDetails.Location = new System.Drawing.Point(114, 117);
            this.btnSupplierDetails.Name = "btnSupplierDetails";
            this.btnSupplierDetails.Size = new System.Drawing.Size(146, 45);
            this.btnSupplierDetails.TabIndex = 1;
            this.btnSupplierDetails.Text = "supplierDetails";
            this.btnSupplierDetails.UseVisualStyleBackColor = true;
            this.btnSupplierDetails.Click += new System.EventHandler(this.btnSupplierDetails_Click);
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDetails.Location = new System.Drawing.Point(114, 188);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(146, 48);
            this.btnProductDetails.TabIndex = 2;
            this.btnProductDetails.Text = "productDetails";
            this.btnProductDetails.UseVisualStyleBackColor = true;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReport.Location = new System.Drawing.Point(114, 266);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(146, 53);
            this.btnCustomerReport.TabIndex = 4;
            this.btnCustomerReport.Text = "customerReport";
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // btnSalesCustomerReport
            // 
            this.btnSalesCustomerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesCustomerReport.Location = new System.Drawing.Point(114, 343);
            this.btnSalesCustomerReport.Name = "btnSalesCustomerReport";
            this.btnSalesCustomerReport.Size = new System.Drawing.Size(146, 53);
            this.btnSalesCustomerReport.TabIndex = 5;
            this.btnSalesCustomerReport.Text = "salesCustomerDetails";
            this.btnSalesCustomerReport.UseVisualStyleBackColor = true;
            this.btnSalesCustomerReport.Click += new System.EventHandler(this.btnSalesCustomerReport_Click);
            // 
            // btnProductReport
            // 
            this.btnProductReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductReport.Location = new System.Drawing.Point(114, 425);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(146, 53);
            this.btnProductReport.TabIndex = 6;
            this.btnProductReport.Text = "ProductReport";
            this.btnProductReport.UseVisualStyleBackColor = true;
            this.btnProductReport.Click += new System.EventHandler(this.btnProductReport_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(376, 490);
            this.Controls.Add(this.btnProductReport);
            this.Controls.Add(this.btnSalesCustomerReport);
            this.Controls.Add(this.btnCustomerReport);
            this.Controls.Add(this.btnProductDetails);
            this.Controls.Add(this.btnSupplierDetails);
            this.Controls.Add(this.btnRegisteration);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisteration;
        private System.Windows.Forms.Button btnSupplierDetails;
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnSalesCustomerReport;
        private System.Windows.Forms.Button btnProductReport;
    }
}