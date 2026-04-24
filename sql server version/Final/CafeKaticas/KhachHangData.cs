using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeKaticas
{
    internal class KhachHangData
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Phu\Documents\cafe.mdf;Integrated Security=True;Connect Timeout=30");

        //public int CustomerID { get; set; }
        //public string TotalPrice {  get; set; }
        //public string Amount { get; set; }
        //public string Change {  get; set; }
        //public string Date { get; set; }

        //public List<KhachHangData> allCustomersData()
        //{
        //    List<KhachHangData> listData = new List<KhachHangData>();

        //    if (connect.State == ConnectionState.Closed)
        //    {
        //        try
        //        {
        //            connect.Open();

        //            string selectData = "SELECT * FROM customers";

        //            using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //            {
        //                SqlDataReader reader = cmd.ExecuteReader();

        //                while (reader.Read())
        //                {
        //                    KhachHangData cData = new KhachHangData();

        //                    cData.CustomerID = (int)reader["customer_id"];
        //                    cData.TotalPrice = reader["total_price"].ToString();
        //                    cData.Amount = reader["amount"].ToString();
        //                    cData.Change = reader["change"].ToString();
        //                    cData.Date = reader["date"].ToString();

        //                    listData.Add(cData);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Ket noi loi: " + ex);
        //        }
        //        finally
        //        {
        //            connect.Close();
        //        }
        //    }
        //    return listData;
        //}
    }
}
