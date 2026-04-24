using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class NhapHangReportControl
    {
        Database db;
        private string maddh;
        public NhapHangReportControl(string maddh)
        {
            db = new Database();
            maddh = maddh;
        }

        public DataTable Report(string maddh)
        {
            string nhreport = $@"SELECT MaHang, TenHang, SoLuong, DonViTinh, Gia FROM ChiTietDonDatHang WHERE MaDonDatHang = '{maddh}'";
            DataTable dt = db.Execute(nhreport);
            return dt;
        }


    }
}
