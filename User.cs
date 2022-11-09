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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnCustomerdetails_Click(object sender, EventArgs e)
        {
            customerDetails cus = new customerDetails();
            cus.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.Show();
            this.Hide();
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            Password_Reset pass = new Password_Reset();
            pass.Show();
            this.Hide();
        }
    }
}
