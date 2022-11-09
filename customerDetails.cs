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
    public partial class customerDetails : Form
    {
        public customerDetails()
        {
            InitializeComponent();
        }
       string Connection  = "Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True";
        private int customerID = 0;
        private void loadGv()
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from customerDetails";
                    cmd.Connection = con;
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        gvCustomer.DataSource = dt;
                        
                    }
                }
            }
        }
            
            private void btnSave_Click(object sender, EventArgs e)
        {
            if(textBoxAddress.Text !="" && textBoxcustomerName.Text !="" && textBoxContact.Text!="")
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        {
                            cmd.CommandText = "spGetCustomerDetails";
                            cmd.Parameters.AddWithValue("@customerName", textBoxcustomerName.Text);
                            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                            cmd.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                            cmd.Parameters.AddWithValue("@customerID", customerID);

                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data saved Succesfully");
                            loadGv();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the blank");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGv();
        }
      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateCustomer1";
                    cmd.Parameters.AddWithValue("@customerName",textBoxcustomerName.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                    cmd.Parameters.AddWithValue("@customerID", customerID);

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
                            cmd.CommandText = "spDeleteCustomer";
                            cmd.Parameters.AddWithValue("@customerID",customerID);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted");
                            loadGv();
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
            customerID = 0;
            textBoxcustomerName.Text ="";
            textBoxAddress.Text = "";
            textBoxContact.Text = "";
        }

        private void gvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerID = int.Parse(gvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxcustomerName.Text = gvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAddress.Text = gvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxContact.Text = gvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

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
                        cmd.CommandText = @"select * from customerDetails where customerName like @Search OR Address like @Search OR Contact = @Search";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Search", "%" + textSearch.Text + "%");
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            gvCustomer.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

