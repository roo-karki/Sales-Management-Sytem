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
    public partial class productDetails : Form
    {
        public productDetails()
        {
            InitializeComponent();
        }
        string Connection = "Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True";
        private int productID = 0;
        private void LoadGv()
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from productDetails";
                    cmd.Connection = con;
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        gvProduct.DataSource = dt;

                    }
                }
            }
        }
        private void LoadSupplierCombo()
        {
            string sql = "select supplierName,supplierID,Contact From Supplier";
            var data = DBConnection.GetTableByQuery(sql);
            cboSupplierID.DataSource = data;
            cboSupplierID.ValueMember = "SupplierID";
            cboSupplierID.DisplayMember ="supplierName";
       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textProductName.Text != "" && textPackageSize.Text != "" && textUnitPrice.Text != "" && cboSupplierID.Text != "" && txtSellingPrice.Text!="")
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        {

                            cmd.CommandText = "spGetProductDetails2";

                            cmd.Parameters.AddWithValue("@productName", textProductName.Text);
                            cmd.Parameters.AddWithValue("@packageSize", textPackageSize.Text);
                            cmd.Parameters.AddWithValue("@unitPrice", textUnitPrice.Text);
                            cmd.Parameters.AddWithValue("@supplierID", cboSupplierID.SelectedValue);
                            cmd.Parameters.AddWithValue("@sellingPrice", txtSellingPrice.Text);
                            cmd.Parameters.AddWithValue("@DateOfSales",dtSales.Value);
                          

                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data saved Succesfully");
                            LoadGv();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the blank");
            }

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult da = MessageBox.Show("Are you sure you want to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (da == DialogResult.Yes)
                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "spDeleteProduct";
                            cmd.Parameters.AddWithValue("@productID", productID);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted");
                            LoadGv();
                        }
                    }

                else
                {
                    MessageBox.Show("The data is not deleted");

                }
            }
            catch (Exception)
            {


                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textPackageSize.Text = "";
            textProductName.Text = "";
            textUnitPrice.Text = "";
            cboSupplierID.Text = "";
            txtSellingPrice.Text = "";
            dtSales.Text = "";

        }

        private void gvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productID = int.Parse(gvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
            textProductName.Text = gvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPackageSize.Text = gvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            textUnitPrice.Text = gvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSellingPrice.Text = gvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtSales.Text = gvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"select * from productDetails where productName like @Search OR packageSize like @Search OR  unitPrice like  @Search OR supplierID like @Search";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Search", "%" + textSearch.Text + "%");
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            gvProduct.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateProductDetails";
                    cmd.Parameters.AddWithValue("@productName", textProductName.Text);
                    cmd.Parameters.AddWithValue("@packageSize", textPackageSize.Text);
                    cmd.Parameters.AddWithValue("@unitPrice", textUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@supplierID", cboSupplierID.SelectedValue);
                    cmd.Parameters.AddWithValue("@sellingPrice",txtSellingPrice.Text);
                    cmd.Parameters.AddWithValue("@DateOfSales", dtSales.Text);

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Sucessfully ");
                    LoadGv();

                }
            }
        }

        private void productDetails_Load(object sender, EventArgs e)
        {
            LoadSupplierCombo();
            LoadGv();
            
        }
    }
}
    

