using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    class AddProductControl
    {
        Database db;
        public AddProductControl()
        {
            db = new Database();
        }

        public DataTable BangTonKho()
        {
            string query = "SELECT MaHang, TenHang, SoLuong, DonViTinh, Gia, TrangThai FROM HangHoa;";
            DataTable dt = db.Execute(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn kho!");
            }
            return dt;
        }

        public bool CheckID(string id)
        {
            string checkquery = $"SELECT MaHang FROM HangHoa WHERE MaHang = '{id}'";
            DataTable dt = db.Execute(checkquery);
            if (dt.Rows.Count == 0) { return false; }
            return true;
        }

        public void AddProduct(string id, string name, int stock, string dvt, float price, string status)
        {
            string addquery = $"INSERT INTO HangHoa (MaHang, TenHang, SoLuong, DonViTinh, Gia, TrangThai)" +
                $"VALUES('{id}', N'{name}', '{stock}', N'{dvt}', '{price}', N'{status}')";

            db.ExecuteNonQuery(addquery);
        }

        public void UpdateProduct(string id, string name, int stock, string dvt, float price, string status)
        {
            string updatequery = $"UPDATE HangHoa SET TenHang = N'{name}', SoLuong = '{stock}', DonViTinh = N'{dvt}', Gia = '{price}', TrangThai = N'{status}' WHERE  MaHang = '{id}'";

            db.ExecuteNonQuery(updatequery);
        }

        public void DeleteProduct(string id) 
        {
            string deletequery = $"DELETE FROM HangHoa WHERE MaHang = '{id}'";

            db.ExecuteNonQuery(deletequery);
        }

        public List<string> OutOfStock()
        {
            string outodstockquery = $"SELECT TenHang FROM HangHoa WHERE SoLuong = 0";
            DataTable dt = db.Execute(outodstockquery);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["TenHang"].ToString());
            }
            return list;
        }

        public void UpdateTonkho(string maHang, int soLuongNhap)
        {
            string queryUpdateTonKho = $@" UPDATE HangHoa SET SoLuong = SoLuong + '{soLuongNhap}' WHERE MaHang = '{maHang}'";
            db.ExecuteNonQuery(queryUpdateTonKho);
        }

    }
}
