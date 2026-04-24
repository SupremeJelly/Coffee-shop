using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class ChiTietNhapHangControl
    {
        Database db = new Database();
        public DataTable ChiTietNhapHang(string maDonDatHang)
        {
            string lsnh = $@"SELECT MaHang, TenHang, SoLuong, DonViTinh, Gia FROM ChiTietDonDatHang WHERE  MaDonDatHang = N'{maDonDatHang}'";
            DataTable dt = db.Execute(lsnh);
            return dt;
        }
        public DataTable QuyDoi()
        {
            string queryQuyDoi = "SELECT DonViLon, DonViNho, SoLuong FROM QuyDoi";
            DataTable dtquydoi = db.Execute(queryQuyDoi);
            return dtquydoi;
        }

        public void UpdateDonDatHang(string maddh)
        {
            string query = $@"UPDATE DonDatHang SET TrangThai = N'Đã xử lý' WHERE MaDonDatHang = N'{maddh}'";
            db.ExecuteNonQuery(query);
        }
    }
}
