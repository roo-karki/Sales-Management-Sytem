using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_management_sytem_c
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
            Registeration reg = new Registeration();
            reg.Show();
            this.Hide();
        }

        private void btnSupplierDetails_Click(object sender, EventArgs e)
        {
            supplierDetails sup = new supplierDetails();
            sup.Show();
            this.Hide();
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            productDetails pro = new productDetails();
            pro.Show();
            this.Hide();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            customerReport cus = new customerReport();
            cus.Show();
            this.Hide();
        }

        private void btnSalesCustomerReport_Click(object sender, EventArgs e)
        {
            SalesCustomerDetails sales = new SalesCustomerDetails();
            sales.Show();
            this.Hide();
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            productDetails pro = new productDetails();
            pro.Show();
            this.Hide();

        }
    }
}
