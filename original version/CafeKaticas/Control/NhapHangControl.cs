using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class NhapHangControl
    {
        Database db = new Database();
        public DataTable NhapHang()
        {
            string ddhquery = @"SELECT MaDonDatHang, NgayDat, TongTien, TrangThai FROM DonDatHang WHERE TrangThai = N'Đang xử lý'";
            DataTable dt = db.Execute(ddhquery);
            return dt;
        }

        public DataTable TimKiem(DateTime timkiem)
        {
            string tk = $"SELECT * FROM DonDatHang WHERE TrangThai = N'Đang xử lý'";
            if (timkiem != DateTime.MinValue)
            {
                string ngaydat = timkiem.ToString("yyyy-MM-dd");
                tk += $" AND NgayDat = '{ngaydat}'";
            }
            DataTable dt = db.Execute(tk);
            return dt;
        }
    }
}
