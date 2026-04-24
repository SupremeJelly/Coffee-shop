using MongoDB.Bson;
using MongoDB.Driver;
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

        public List<BsonDocument> NhaCungCap()
        {
            var filter = new BsonDocument();
            return db.Find("NhaCungCap", filter);
        }

        public List<BsonDocument> HangHoa()
        {
            var filter = new BsonDocument();
            return db.Find("HangHoa", filter);
        }

        public BsonDocument Hang(string mahang)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", mahang);
            var result = db.Find("HangHoa", filter);
            return result.FirstOrDefault();
        }

        public string GenerateMaDonDatHang()
        {
            long count = db.CountDocuments("DonDatHang");
            return $"DDH{count + 1:D5}";
        }

        public void AddDonDatHang(string ma, string ncc, DateTime ngay, float tongtien)
        {
            var document = new BsonDocument
            {
                { "MaDonDatHang", ma },
                { "MaNhaCC", ncc },
                { "NgayDat", ngay },
                { "TongTien", tongtien },
                { "TrangThai", "Đang xử lý" }
            };
            db.Insert("DonDatHang", document);
        }

        public void AddChiTietDonDatHang(string maddh, string mahh, string ten, string dvt, int sl, float gia)
        {
            var document = new BsonDocument
            {
                { "MaDonDatHang", maddh },
                { "MaHang", mahh },
                { "TenHang", ten },
                { "SoLuong", sl },
                { "DonViTinh", dvt },
                { "Gia", gia }
            };
            db.Insert("ChiTietDonDatHang", document);
        }

        public string GetMaNCC(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Ten", name);
            var result = db.Find("NhaCungCap", filter);
            return result.FirstOrDefault()?["MaNCC"].ToString();
        }
    }
}
