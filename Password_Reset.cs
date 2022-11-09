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
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

namespace sales_management_sytem_c
{
    public partial class Password_Reset : Form
    {
        public Password_Reset()
        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection("Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
        ErrorProvider er = new ErrorProvider();
        string pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
        private void btnReset_Click(object sender, EventArgs e)
        {
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Registeration where UserName='" + textUserName.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);  //get the user password from db if the user name is exist in that.  
                IsExist = true;
            }
            con.Close();
            if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
            {
                if (Cryptography.Decrypt(Password).Equals(textOldPassword.Text))
                {
                    if (Regex.IsMatch(textNewPassword.Text, pattern) == false)
                    {
                        MessageBox.Show("please enter required critearea for password!");
                        textNewPassword.Clear();
                    }
                    else if (textNewPassword.Text.ToString().Trim().ToLower() == textNewPassword.Text.ToString().Trim().ToLower())
                    {
                        if (textNewPassword.Text == textConfirmPassword.Text)
                        {
                            string UserName =textUserName.Text;
                            string Password2 = Cryptography.Encrypt(textNewPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                            con.Open();
                            SqlCommand insert = new SqlCommand("Update Registeration set Password='" + Password2 + "' where UserName='" + textUserName.Text + "'", con);
                            insert.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textUserName.Clear();
                            textOldPassword.Clear();
                            textNewPassword.Clear();
                            textConfirmPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("confirm password do not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("oldPassword is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textOldPassword.Clear();
                        textOldPassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("oldPassword is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textOldPassword.Clear();
                    textOldPassword.Focus();
                }

            }
            else  //showing the error message if user credential is wrong  
            {
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textOldPassword.UseSystemPasswordChar = false;
                textNewPassword.UseSystemPasswordChar = false;
                textConfirmPassword.UseSystemPasswordChar = false;

            }
            else
            {
                textOldPassword.UseSystemPasswordChar = true;
                textNewPassword.UseSystemPasswordChar = true;
                textConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
