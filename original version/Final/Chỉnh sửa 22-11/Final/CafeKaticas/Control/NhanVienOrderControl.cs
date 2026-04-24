using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeKaticas
{
    class NhanVienOrderControl
    {
        Database db;

        public NhanVienOrderControl()
        {
            db = new Database();
        }

        public DataTable GetAvailableOrders()
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE MaSanPham IS NOT NULL;";
            DataTable dt = db.Execute(query);
            return dt;
        }

        public float CalculateTotalPrice()
        {
            try
            {
                string query = "SELECT SUM(ISNULL(Gia * SoLuong, 0)) FROM ChiTietHoaDon;";
                object result = db.ExecuteScalar(query);

                if (result == null || result == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToSingle(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void AddOrder(string ten, string id, int sl, float totalPrice, DateTime date, string type, float donprice)
        {
            string checkStockQuery = $"SELECT SoLuong FROM HangHoa WHERE MaHang = (SELECT NguyenLieu FROM Mon WHERE MaMon = '{id}')";
            object result = db.ExecuteScalar(checkStockQuery);

            if (result == null || Convert.ToInt32(result) < sl)
            {

                MessageBox.Show("Số lượng sản phẩm không đủ trong kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string insertQuery = $"INSERT INTO ChiTietHoaDon (MaSanPham, SoLuong, Gia, Ngay, Loai,TenMon, DonGia) VALUES ('{id}', {sl}, {totalPrice}, '{DateTime.Now}', '{type}','{ten}', '{donprice}')";
            db.ExecuteNonQuery(insertQuery);
        }

        public void AddOrderToHoaDon(float totalPrice, DateTime date)
        {
            string insertQuery = $"INSERT INTO HoaDon ( Ngay, TongTien)  VALUES ( '{DateTime.Now}', '{totalPrice}')";
            db.ExecuteNonQuery(insertQuery);
        }

        public void DeleteProductFromOrder(string productId)
        {
            try
            {
                string query = "DELETE FROM ChiTietHoaDon WHERE MaSanPham = '" + productId + "'";

                db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetOrder()
        {
            string resetQuery = $"DELETE FROM ChiTietHoaDon";
            db.ExecuteNonQuery(resetQuery);
            string resetIdentityQuery = "DBCC CHECKIDENT ('ChiTietHoaDon', RESEED, 0)";
            db.ExecuteNonQuery(resetIdentityQuery);
        }

        public void DeleteOrder(string MaHoaDon)
        {
            string deleteQuery = $"DELETE FROM ChiTietHoaDon WHERE MaHoaDon = {MaHoaDon}";
            db.ExecuteNonQuery(deleteQuery);
        }

        public void TTOrder(float tong, DateTime today, float thua, float nhan)
        {
            string TTQuery = $"INSERT INTO HoaDon (TongTien, Ngay,TienThua,TienNhan) VALUES( {tong}, '{DateTime.Now}',{thua},{nhan})";
            db.ExecuteNonQuery(TTQuery);
        }

        public void UpdateKho(string itemId, int quantity)
        {
            string updateQuery = $"UPDATE HangHoa SET SoLuong = SoLuong - {quantity} WHERE MaHang  = (SELECT NguyenLieu FROM Mon WHERE MaMon = '{itemId}')";
            db.ExecuteNonQuery(updateQuery);
        }

        
    }
}