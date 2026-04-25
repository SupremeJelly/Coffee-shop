using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class DashBoardControl
    {
        Database db;
        public DashBoardControl()
        {
            db = new Database();
        }

        public int TongNhanVien()
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE ChucVu = N'Nhân Viên' AND TrangThai = N'Da kich hoat'";
            return db.IntExecuteScalar(query);
        }

        public int TongSoHoaDon()
        {
            string query = "SELECT COUNT(*) FROM HoaDon";
            return db.IntExecuteScalar(query);
        }

        public float DoanhThuNgay()
        {
            DateTime date = DateTime.Now;
            string query = $"SELECT SUM(TongTien) FROM HoaDon WHERE Ngay = '{date}'";
            return db.FloatExecuteScalar(query);
        }

        public float TongDoanhThu()
        {
            string query = "SELECT SUM(TongTien) FROM HoaDon";
            return db.FloatExecuteScalar(query);
        }

        public string BestSeller()
        {
            string query = "SELECT TOP 1 m.TenMon, SUM(c.SoLuong) AS TongSoLuong " +
                           "FROM ChiTietHoaDon c " +
                           "JOIN Mon m ON c.MaSanPham = m.MaMon " +
                           "GROUP BY m.TenMon " +
                           "ORDER BY TongSoLuong DESC";
            string bestseller = db.StringExecuteScalar(query);
            return bestseller;
        }
    }
}
