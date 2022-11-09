using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sales_management_sytem_c
{
    public partial class SalesCustomerDetails : Form
    {
        public SalesCustomerDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = Kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
        private void LoadCustomerCombo()
        {
            string sql = "select customerID,customerName From customerDetails";
            var data = DBConnection.GetTableByQuery(sql);
            cmbCustomer.DataSource = data;
            cmbCustomer.DisplayMember = "customerName";
            cmbCustomer.ValueMember = "customerName";
        }
        private void SalesCustomerDetails_Load(object sender, EventArgs e)
        {
            LoadCustomerCombo();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from orderDetails where customerName='" + cmbCustomer.SelectedValue + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GvSalesDetails.DataSource = dt;
        }
    }
}
