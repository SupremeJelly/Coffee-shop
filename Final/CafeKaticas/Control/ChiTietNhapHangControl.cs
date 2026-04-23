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
    class ChiTietNhapHangControl
    {
        Database db = new Database();
        public List<BsonDocument> ChiTietNhapHang(string maDonDatHang)
        {
            var collection = db.GetCollection("ChiTietDonDatHang");
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maDonDatHang);
            return collection.Find(filter).ToList();
        }
        public void CapNhatTrangThaiDonDatHang(string maDonDatHang)
        {
            var collection = db.GetCollection("DonDatHang");
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maDonDatHang);
            var update = Builders<BsonDocument>.Update.Set("TrangThai", "Đã xử lý");

            collection.UpdateOne(filter, update);
        }
    }
}
