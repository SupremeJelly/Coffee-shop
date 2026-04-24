using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class LichSuNhapHangControl
    {
        Database db = new Database();
        public DataTable LichSuNhapHang()
        {
            string lsnhquery = "SELECT MaDonDatHang, NgayDat, TongTien, TrangThai FROM DonDatHang WHERE TrangThai = N'Đã xử lý'";
            DataTable dt = db.Execute(lsnhquery);
            return dt;
        }
    }
}
