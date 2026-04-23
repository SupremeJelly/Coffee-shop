using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class LSNHControl
    {
        Database db;

        public LSNHControl()
        {
            db = new Database();
        }

        public List<BsonDocument> NhapHang()
        {
            var collection = db.GetCollection("DonDatHang");
            var filter = Builders<BsonDocument>.Filter.Eq("TrangThai", "Đã xử lý");
            return collection.Find(filter).ToList();
        }

        public List<BsonDocument> ChiTietNhapHang(string maddh)
        {
            var collection = db.GetCollection("ChiTietDonDatHang");
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            return collection.Find(filter).ToList();
        }

    }
}
