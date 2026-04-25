using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class DatHangControl
    {
        Database db = new Database();

        public DataTable NhaCungCap()
        {
            string nccquery = "SELECT MaNCC,Ten FROM NhaCungCap";
            DataTable dt = db.Execute(nccquery);
            return dt;
        }

        public DataTable HangHoa()
        {
            string query = "SELECT MaHang, TenHang, DonViTinh, Gia FROM HangHoa";
            DataTable dt = db.Execute(query);
            return dt;
        }

        public DataRow Hang(string mahang)
        {
            string nccquery = $"SELECT MaHang,TenHang, DonViTinh, Gia FROM HangHoa WHERE MaHang = N'{mahang}'";
            DataTable dt = db.Execute(nccquery);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

        public void AddDonDatHang(string ma, string ncc, DateTime ngay, float tongtien)
        {
            string adddon = $"INSERT INTO DonDatHang(MaDonDatHang,MaNhaCC,NgayDat,TongTien,TrangThai)" +
                            $"VALUES('{ma}','{ncc}','{ngay}','{tongtien}',N'Đang xử lý')";
            db.ExecuteNonQuery(adddon);
        }

        public void AddChiTietDonDatHang(string maddh, string mahh, string ten, string dvt, int sl, float gia)
        {
            string addctddh = $"INSERT INTO ChiTietDonDatHang(MaDonDatHang,MaHang,TenHang,SoLuong,DonViTinh,Gia)" +
                            $"VALUES('{maddh}','{mahh}',N'{ten}','{sl}',N'{dvt}','{gia}')";
            db.ExecuteNonQuery(addctddh);
        }

        public string GetMaNCC(string name)
        {
            string getMancc = $"SELECT DISTINCT MaNCC FROM NhaCungCap WHERE Ten = N'{name}'";
            string ma = db.StringExecuteScalar(getMancc);
            return ma;
        }
    }
}
