using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CafeKaticas
{
    class CTDDHControl
    {
        Database db = new Database();

        public List<BsonDocument> CTDDH(string maddh)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            var collection = db.GetCollection("ChiTietDonDatHang");
            return collection.Find(filter).ToList();
        }
    }
}