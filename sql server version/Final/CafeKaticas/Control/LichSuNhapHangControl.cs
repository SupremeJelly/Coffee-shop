using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CafeKaticas
{
    class LichSuNhapHangControl
    {
        Database db = new Database();

        public List<BsonDocument> LichSuNhapHang()
        {
            var collection = db.GetCollection("DonDatHang");
            var filter = Builders<BsonDocument>.Filter.Eq("TrangThai", "Đã xử lý");
            return collection.Find(filter).ToList();
        }
    }
}
