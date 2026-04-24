using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace CafeKaticas
{
    class NhanVienOrderControl
    {
        private Database db;

        public NhanVienOrderControl()
        {
            db = new Database();
        }

        public List<BsonDocument> GetAvailableProducts()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("TrangThai", "Còn bán");
            return db.GetCollection("HangHoa").Find(filter).ToList();
        }

        public List<BsonDocument> SearchProduct(string mahang)
        {
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("TrangThai", "Còn bán"),
                Builders<BsonDocument>.Filter.Eq("MaHang", mahang)
            );
            return db.GetCollection("HangHoa").Find(filter).ToList();
        }

        public void TTOrder(string Ma, float tong, DateTime today)
        {
            var collection = db.GetCollection("HoaDon");

            var document = new BsonDocument
            {
                { "MaHoaDon", Ma },
                { "TongTien", tong },
                { "Ngay", today }
            };

            collection.InsertOne(document);
        }

        public void CTOrder(string mahd, string ma, string ten, int sl, float gia, DateTime today)
        {
            var collection = db.GetCollection("ChiTietHoaDon");

            var document = new BsonDocument
            {
                { "MaHoaDon", mahd },
                { "MaHang", ma },
                { "TenHang", ten },
                { "SoLuong", sl },
                { "Gia", gia },
                { "Ngay", today }
            };

            collection.InsertOne(document);
        }

        public bool CheckStock(string itemId, int quantity)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", itemId);
            var product = db.GetCollection("HangHoa").Find(filter).FirstOrDefault();

            if (product != null)
            {
                int stock = product["SoLuong"].ToInt32();
                return stock >= quantity;
            }

            return false;
        }

        public void UpdateStock(string itemId, int quantity)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", itemId);
            var update = Builders<BsonDocument>.Update.Inc("SoLuong", -quantity);
            db.GetCollection("HangHoa").UpdateOne(filter, update);
        }

        public string GenerateMaHoaDon()
        {
            long count = db.CountDocuments("HoaDon");
            return $"HD{count + 1:D5}";
        }
    }
}
