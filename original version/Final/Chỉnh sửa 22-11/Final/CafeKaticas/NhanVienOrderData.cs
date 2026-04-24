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
    class NhanVienOrderData
    {
        public int Số { get; set; }
        public string Mã { get; set; }
        public string Tên { get; set; }
        public string Loại { get; set; }
        public int Lượng { get; set; }

        public string Giá { get; set; }


        public List<NhanVienOrderData> ordersListData()
        {
            List<NhanVienOrderData> listData = new List<NhanVienOrderData>();
            string connectionString = @"Data Source=MY-DESKTOP;Initial Catalog=KATICAS;Integrated Security=True;";

            string selectCustData = "SELECT MAX(MaHoaDon) FROM HoaDon";

            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCustData, connectionString))
            {
                DataTable custData = new DataTable();
                try
                {
                    adapter.Fill(custData);

                    int custID = 0;
                    if (custData.Rows.Count > 0)
                    {
                        object result = custData.Rows[0][0];
                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);
                            custID = temp == 0 ? 1 : temp;
                        }
                        else
                        {
                            Console.WriteLine("Lỗi ID");
                        }
                    }

                    string selectOrders = "SELECT * FROM ChiTietHoaDon";

                    using (SqlDataAdapter orderAdapter = new SqlDataAdapter(selectOrders, connectionString))
                    {
                        orderAdapter.SelectCommand.Parameters.AddWithValue("@MaHoaDon", custID);

                        DataTable ordersData = new DataTable();
                        orderAdapter.Fill(ordersData);

                        foreach (DataRow row in ordersData.Rows)
                        {
                            NhanVienOrderData orderData = new NhanVienOrderData
                            {
                                Số = Convert.ToInt32(row["id"]),
                                Mã = row["MaSanPham"].ToString(),
                                Tên = row["TenMon"].ToString(),
                                Loại = row["Loai"].ToString(),
                                Lượng = Convert.ToInt32(row["SoLuong"]),
                                Giá = row["Gia"].ToString()
                            };
                            listData.Add(orderData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Kết nối lỗi: " + ex);
                }
            }

            return listData;
        }
    }

}
