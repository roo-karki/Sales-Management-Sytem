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
    public partial class Registeration : Form
    {
        public Registeration()   
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection( "Data Source = Kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
        string pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
        const int len = 7;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" && textBoxRetypePassword.Text == "" && textBoxPassword.Text == "")
            {

                MessageBox.Show("All detail are Necessary to Fill");

            }

            else if (textBoxPassword.Text != textBoxRetypePassword.Text)
            {

                MessageBox.Show("password do not match with Comfirm-Password");

                textBoxRetypePassword.Clear();
                textBoxPassword.Focus();
            }
            else
            {
                if (Regex.IsMatch(textBoxPassword.Text, pattern) == false)
                {
                    MessageBox.Show("Please enter required criteria for password!");
                    textBoxPassword.Clear();
                    textBoxRetypePassword.Focus();
                }

                else if (textBoxPassword.Text.ToString().Trim().ToLower() == textBoxRetypePassword.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    string UserName = textBoxUserName.Text;
                    string Password = Cryptography.Encrypt(textBoxPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    con.Open();
                    SqlCommand insert = new SqlCommand("insert into Registeration (fullName,UserName,Email,Password,userType)values('" + textBoxFullName.Text + "','" + UserName + "','" + textBoxEmail.Text + "','" + Password + "','" + cboUserType.Text + "')", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                    Clear();
                }

            }

        }
        private void Clear()
        {
            textBoxFullName.Text= textBoxUserName.Text= textBoxEmail.Text= textBoxPassword.Text = textBoxRetypePassword.Text =cboUserType.Text="" ;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxRetypePassword.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxRetypePassword.UseSystemPasswordChar = true;
            }
        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }
    }

}
        
    


