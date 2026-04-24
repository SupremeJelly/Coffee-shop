using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class MauDDHControl
    {
        Database db;
        private string maddh;

        public MauDDHControl(string maddh)
        {
            db = new Database();
            maddh = maddh;
        }

        public DataTable DonDatHang(string maddh)
        {
            string ddh = $@"SELECT * FROM DonDatHang WHERE MaDonDatHang = '{maddh}'";
            DataTable dt = db.Execute(ddh);
            return dt;
        }

        public DataTable ChiTietDonDatHang(string maddh)
        {
            string ddh = $@"SELECT * FROM ChiTietDonDatHang WHERE MaDonDatHang = '{maddh}'";
            DataTable dt = db.Execute(ddh);
            return dt;
        }

        public DataTable NhaCungCap(string maddh)
        {
            string ddh = $@"SELECT ncc.Ten AS Ten
            FROM DonDatHang ddh
            JOIN NhaCungCap ncc ON ddh.MaNhaCC = ncc.MaNCC
            WHERE ddh.MaDonDatHang = '{maddh}'";
            DataTable dt = db.Execute(ddh);
            return dt;
        }
    }
}
