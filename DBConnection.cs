using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace sales_management_sytem_c
{
    class DBConnection
    {
        public static SqlConnection DbConnect()
        {
            var con = new SqlConnection();
            con.ConnectionString = ("Data Source = kathmandu; Initial Catalog = Salesmanagementsystem; Integrated Security = True");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;

        }

        public static DataSet GetDataSet(string SqlQuery)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DbConnect();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DbConnect();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DbConnect();
                cmd.CommandText = SqlQuery;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
    

