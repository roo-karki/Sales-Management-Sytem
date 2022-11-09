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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        string Connection = "Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True";
        private void LoadCustomerCombo()
        {
            string sql = "select customerName From customerDetails";
            var data = DBConnection.GetTableByQuery(sql);
            cmbCustomerName.DataSource = data;
            cmbCustomerName.DisplayMember = "customerName";
            cmbCustomerName.ValueMember = "customerName";
        }
        private void Clear()
        {
            txtProductName.Text = "";
            txtSaleRate.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "";

        }
        void CalculateTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < gvOrder.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(gvOrder.Rows[i].Cells[3].Value);
            }
            lbTotalPurchase.Text = sum.ToString();
        }


        private void Order_Load(object sender, EventArgs e)
        {

            LoadCustomerCombo();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //GvPurchase.Rows.RemoveAt(int.Parse(GvPurchase.CurrentCell.RowIndex.ToString()));
            int rowindex = gvOrder.CurrentCell.RowIndex;
            gvOrder.Rows.RemoveAt(rowindex);
            CalculateTotal();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
              
                string sql = "insert into orderItem values ('" + txtInvoiceNumber.Text + "','" + cmbCustomerName.SelectedValue + "','" + DtOrder.Value.ToString() + "')";
                DBConnection.ExecuteNonQuery(sql);

                
                
                if (gvOrder.Rows.Count > 0)
                {


                    for (int i = 0; i < gvOrder.Rows.Count - 1; i++)
                    {
                     
                        string col1 = gvOrder.Rows[i].Cells[0].Value.ToString();

                        string col2 = gvOrder.Rows[i].Cells[1].Value.ToString();

                        string col3 = gvOrder.Rows[i].Cells[2].Value.ToString();

                        string col4 = gvOrder.Rows[i].Cells[3].Value.ToString();

                        string sql2 = "insert into dbo.[orderDetails] values ('" + col1.ToString() + "','" + col2.ToString() + "','" + col3.ToString() + "','" + col4.ToString() + "','" + cmbCustomerName.SelectedValue + "')";
                        DBConnection.ExecuteNonQuery(sql2);
                    }
                }
            
                foreach (DataGridViewRow row in gvOrder.Rows)
                {
                    int q = 0;
                    string pname = "";
                    q = Convert.ToInt32(row.Cells[2].Value);
                    pname = Convert.ToString(row.Cells[0].Value);

                    string sql3 = "update productDetails set packageSize= packageSize - '" + q + "' where productName='" + pname.ToString() + "'";
                    DBConnection.ExecuteNonQuery(sql3);
                }
                txtInvoiceNumber.Text = "";
                cmbCustomerName.Text = "";
                DtOrder.Text = "";
                txtProductName.Text = "";
                txtSaleRate.Text = "";
                txtQuantity.Text = "";
                txtTotal.Text = "";
                lbTotalPurchase.Text = "";
                MessageBox.Show("Detail saved sucessfully");

                LoadCustomerCombo();
                gvOrder.Rows.Clear();
            }


            private void btnBack_Click(object sender, EventArgs e)
            {
               // MainForm main = new MainForm();
                //main.Show();
                this.Hide();
            }

            private void BtnNew_Click(object sender, EventArgs e)
            {
                txtProductName.Focus();
            }

            private void BtnReset_Click(object sender, EventArgs e)
            {
                txtInvoiceNumber.Text = "";
                cmbCustomerName.Text = "";
                DtOrder.Text = "";
                txtProductName.Text = "";
                txtSaleRate.Text = "";
                txtQuantity.Text = "";
                txtTotal.Text = "";
                lbTotalPurchase.Text = "";
            }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Quantity = 0;

            string sql = "select * from ProductDetails where productName= '" + txtProductName.Text + "'";
            DBConnection.ExecuteNonQuery(sql);
            var ds = DBConnection.GetTableByQuery(sql);
            foreach (DataRow dr in ds.Rows)
            {

                Quantity = int.Parse(dr["packageSize"].ToString());
            }
            if (int.Parse(txtQuantity.Text.ToString()) > int.Parse(Quantity.ToString()))
            {
                MessageBox.Show("this much qty is not available");
            }
            else
            {
                try
                {
                    bool found = false;



                    if (gvOrder.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in gvOrder.Rows)
                        {


                            if (Convert.ToString(row.Cells[0].Value) == txtProductName.Text && Convert.ToString(row.Cells[1].Value) == txtSaleRate.Text)
                            {
                                row.Cells[2].Value = (Convert.ToString(Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(row.Cells[2].Value)));
                                row.Cells[3].Value = (Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value));
                                found = true;

                            }
                        }

                        CalculateTotal();


                        //loadstock();
                        if (!found)
                        {
                            gvOrder.Rows.Add(txtProductName.Text, txtSaleRate.Text, txtQuantity.Text, txtTotal.Text);
                            CalculateTotal();


                            Clear();
                        }

                    }
                    else
                    {
                        gvOrder.Rows.Add(txtProductName.Text, txtSaleRate.Text, txtQuantity.Text, txtTotal.Text);
                        CalculateTotal();

                        Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
        }

        private void txtProductName_KeyUp_1(object sender, KeyEventArgs e)
        {
            LbProductName.Visible = true;
            LbProductName.Items.Clear();
            string sql = "select * from productDetails where productName like ('" + txtProductName.Text + "%')";
            DBConnection.ExecuteNonQuery(sql);
            var ds = DBConnection.GetTableByQuery(sql);
            foreach (DataRow dr in ds.Rows)
            {
                LbProductName.Items.Add(dr["productName"].ToString());
            }
        }

        private void txtQuantity_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (float.Parse(txtSaleRate.Text) * float.Parse(txtQuantity.Text)).ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSaleRate_Enter_1(object sender, EventArgs e)
        {
            string sql = "select top 1 * from productDetails where productName ='" + txtProductName.Text + "' order by ProductID desc";
            DBConnection.ExecuteNonQuery(sql);
            var ds = DBConnection.GetTableByQuery(sql);
            foreach (DataRow dr in ds.Rows)
            {
                txtSaleRate.Text = dr["sellingPrice"].ToString();
            }
        }

        private void txtProductName_KeyDown_1(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Down)
                {
                    LbProductName.Focus();
                    LbProductName.SelectedIndex = 0;
                }
            
        }

        private void LbProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.LbProductName.SelectedIndex = this.LbProductName.SelectedIndex + 1;

                }
                if (e.KeyCode == Keys.Up)
                {
                    this.LbProductName.SelectedIndex = this.LbProductName.SelectedIndex - 1;

                }
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductName.Text = LbProductName.SelectedItem.ToString();
                    LbProductName.Visible = false;
                    txtSaleRate.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void LbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

