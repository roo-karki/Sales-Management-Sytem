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
    public partial class supplierDetails : Form
    {
        public supplierDetails()
        {
            InitializeComponent();
        }
        string Connection = "Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True";
        private int supplierID = 0;
        private void loadGv()
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from supplierDetails";
                    cmd.Connection = con;
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        gvSupplier.DataSource = dt;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textCompany.Text != "" && textContactName.Text != "" && textAddress.Text != "" && textContact.Text != "")
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        {

                            cmd.CommandText = "spGetSupplierDetails";

                            cmd.Parameters.AddWithValue("@Company", textCompany.Text);
                            cmd.Parameters.AddWithValue("@contactName", textContactName.Text);
                            cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                            cmd.Parameters.AddWithValue("@Contact", textContact.Text);

                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data saved Succesfully");
                            loadGv();
                        }
                    }
                }
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
                    cmd.CommandText = "spUpdateSupplierDetails1";
                    cmd.Parameters.AddWithValue("@Company", textCompany.Text);
                    cmd.Parameters.AddWithValue("@contactName",textContactName.Text);
                    cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    cmd.Parameters.AddWithValue("@contact", textContact.Text);

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Sucessfully ");
                    loadGv();

                }
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
                            cmd.CommandText = "spDeleteSupplier";
                            cmd.Parameters.AddWithValue("@supplierID", supplierID);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted");
                            loadGv();
                        }
                    }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textCompany.Text = "";
            textContactName.Text = "";
            textAddress.Text = "";
            textContact.Text = "";
             
        }

        private void gvSupplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplierID = int.Parse(gvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
            textCompany.Text = gvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            textContactName.Text = gvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            textAddress.Text = gvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            textContact.Text = gvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
            
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
                        cmd.CommandText = @"select * from supplierDetails where Company like @Search OR contactName like @Search OR Address = @Search OR Contact like @Search";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Search", "%" + textSearch.Text + "%");
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            gvSupplier.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void supplierDetails_Load(object sender, EventArgs e)
        {

        }
    }
    }

