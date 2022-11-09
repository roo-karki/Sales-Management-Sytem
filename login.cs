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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection( "Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUserName.Text == "" && textPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password");
                }
                else
                {
                    string Password = "";
                    bool IsExist = false;

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Registeration where UserName='" + textUserName.Text + "'and UserType='" + cboUserType.Text + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Password = sdr.GetString(4);  // will get the user and password from db if the user name is exist in that.  
                        IsExist = true;
                    }
                    con.Close();
                    if (IsExist)  //if record exist in db , it will return true, otherwise it will return false.  
                    {
                        if (Cryptography.Decrypt(Password).Equals(textPassword.Text))
                        {
                            MessageBox.Show("successfully login as " + cboUserType.SelectedItem);
                            if (cboUserType.SelectedIndex == 0)
                            {
                                Admin a = new Admin();
                                a.Show();
                                this.Hide();
                            }
                            else
                            {
                                User u = new User();
                                u.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password is Incorrect!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else  //showing the error message if user credential is wrong  
                    {
                        MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;

            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
