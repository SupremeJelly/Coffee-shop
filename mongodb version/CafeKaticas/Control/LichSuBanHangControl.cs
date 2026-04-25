using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CafeKaticas
{
    class LichSuBanHangControl
    {
        Database db = new Database();

        public List<BsonDocument> LichSu()
        {
            return db.GetAll("HoaDon");
        }

        public List<BsonDocument> ChiTiet(string mahd)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHoaDon", mahd);
            return db.Find("ChiTietHoaDon", filter);
        }
    }
}