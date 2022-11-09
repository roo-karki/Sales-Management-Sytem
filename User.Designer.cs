namespace sales_management_sytem_c
{
    partial class User
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
            this.btnCustomerdetails = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPasswordReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerdetails
            // 
            this.btnCustomerdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerdetails.Location = new System.Drawing.Point(81, 44);
            this.btnCustomerdetails.Name = "btnCustomerdetails";
            this.btnCustomerdetails.Size = new System.Drawing.Size(162, 53);
            this.btnCustomerdetails.TabIndex = 0;
            this.btnCustomerdetails.Text = "customerDetails";
            this.btnCustomerdetails.UseVisualStyleBackColor = true;
            this.btnCustomerdetails.Click += new System.EventHandler(this.btnCustomerdetails_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(81, 155);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(162, 53);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPasswordReset
            // 
            this.btnPasswordReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordReset.Location = new System.Drawing.Point(81, 260);
            this.btnPasswordReset.Name = "btnPasswordReset";
            this.btnPasswordReset.Size = new System.Drawing.Size(162, 53);
            this.btnPasswordReset.TabIndex = 2;
            this.btnPasswordReset.Text = "Password Reset";
            this.btnPasswordReset.UseVisualStyleBackColor = true;
            this.btnPasswordReset.Click += new System.EventHandler(this.btnPasswordReset_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(348, 366);
            this.Controls.Add(this.btnPasswordReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCustomerdetails);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerdetails;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPasswordReset;
    }
}