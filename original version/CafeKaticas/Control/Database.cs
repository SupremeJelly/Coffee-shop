using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    class Database
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string strconn = @"Data Source=LAPTOP-C8ECJ16B;Initial Catalog=KATICAS;Integrated Security=True;";

            conn = new SqlConnection(strconn);
        }

        public DataTable Execute(string query)
        {
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int IntExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }

        public string StringExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            var result = cmd.ExecuteScalar();
            string i;
            if (result == null)
            {
                i = "Không có";
            }
            else
            {
                i = result.ToString();
            }
            
            conn.Close();
            return i;
        }

        public float FloatExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            var result = cmd.ExecuteScalar();

            conn.Close();

            if (result != DBNull.Value)
            {
                return Convert.ToSingle(result);
            }

            return 0f;
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
