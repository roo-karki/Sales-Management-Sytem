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
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from productDetails where DateOfSales between '" + dtFrom.Value.ToString() + "' and '" + dtTo.Value.ToString() + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GvProduct.DataSource = dt;
        }

        private void GvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
