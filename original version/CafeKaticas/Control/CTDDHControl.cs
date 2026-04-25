using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class CTDDHControl
    {
        Database db = new Database();

        public DataTable CTDDH(string maddh)
        {
            string query = $"SELECT MaHang, TenHang, SoLuong, DonViTinh, Gia FROM ChiTietDonDatHang WHERE MaDonDatHang = '{maddh}'";
            DataTable dt = db.Execute(query);
            return dt;

        }
    }
}
