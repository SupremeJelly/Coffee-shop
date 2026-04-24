using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace CafeKaticas
{
    internal class NhanVienOrderProdData
    {
        public string Mã { set; get; }
        public string Tên { set; get; }
        public string Loại { set; get; }
        public string Giá { set; get; }
        public string DonViTinh { set; get; }
        public string NguyenLieu { set; get; }
        public string TrangThai { set; get; }

        public List<NhanVienOrderProdData> availableProductsData()
        {
            List<NhanVienOrderProdData> listData = new List<NhanVienOrderProdData>();
            string connectionString = @"Data Source=MY-DESKTOP;Initial Catalog=KATICAS;Integrated Security=True;";

            string selectData = "SELECT * FROM Mon WHERE TrangThai = N'Đang bán'";
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectData, connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        NhanVienOrderProdData apd = new NhanVienOrderProdData
                        {
                            Mã = row["MaMon"].ToString(),
                            Tên = row["TenMon"].ToString(),         
                            Loại = row["Loai"].ToString(),                 
                            Giá = row["Gia"].ToString(),                 
                            DonViTinh = row["DonViTinh"].ToString(),            
                            NguyenLieu = row["NguyenLieu"].ToString(),     
                            TrangThai = row["TrangThai"].ToString()           
                        };
                        listData.Add(apd);
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
