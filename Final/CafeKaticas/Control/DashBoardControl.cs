//using MongoDB.Bson;
//using MongoDB.Driver;
//using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;

namespace CafeKaticas
{
    class DashBoardControl
    {
        private Database db;

        public DashBoardControl()
        {
            db = new Database();
        }

        public int TongNhanVien()
        {
            var collection = db.GetCollection("NhanVien");
            var filter = Builders<BsonDocument>.Filter.Eq("ChucVu", "Nhân Viên") &
                         Builders<BsonDocument>.Filter.Eq("TrangThai", "Da kich hoat");

            var documents = collection.Find(filter).ToList();
            return documents.Count;
        }

        public int TongSoHoaDon()
        {
            var collection = db.GetCollection("HoaDon");
            var documents = collection.Find(new BsonDocument()).ToList();
            return documents.Count;
        }

        public float DoanhThuNgay()
        {
            var collection = db.GetCollection("HoaDon");
            var today = DateTime.Now.Date;

            var filter = Builders<BsonDocument>.Filter.Eq("Ngay", today);
            var documents = collection.Find(filter).ToList();

            return (float)documents.Sum(doc => doc["TongTien"].ToDouble());
        }

        public float TongDoanhThu()
        {
            var collection = db.GetCollection("HoaDon");
            var documents = collection.Find(new BsonDocument()).ToList();

            return (float)documents.Sum(doc => doc["TongTien"].ToDouble());
        }

        //public string BestSeller()
        //{
        //    var collection = db.GetCollection("ChiTietHoaDon");
        //    var documents = collection.Find(new BsonDocument()).ToList();
        //    var grouped = documents
        //        .GroupBy(doc => doc["MaMon"].AsString)
        //        .Select(group => new
        //        {
        //            MaMon = group.Key,
        //            TongSoLuong = group.Sum(g => g["SoLuong"].ToInt32())
        //        })
        //        .OrderByDescending(g => g.TongSoLuong)
        //        .FirstOrDefault();

        //    if (grouped != null)
        //    {
        //        var monCollection = db.GetCollection("Mon");
        //        var mon = monCollection.Find(Builders<BsonDocument>.Filter.Eq("MaMon", grouped.MaMon)).FirstOrDefault();
        //        return mon?["TenMon"].AsString ?? "Không có";
        //    }

        //    return "Không có";
        //}
    }
}





//namespace CafeKaticas
//{
//    class DashBoardControl
//    {
//        Database db;

//        public DashBoardControl()
//        {
//            db = new Database(); // Sử dụng lớp Database của bạn để kết nối MongoDB
//        }

//        public int TongNhanVien()
//        {
//            string collectionName = "NhanVien";
//            var filter = Builders<BsonDocument>.Filter.Eq("ChucVu", "Nhân Viên") &
//                         Builders<BsonDocument>.Filter.Eq("TrangThai", "Da kich hoat");
//            return db.CountDocuments(collectionName, filter);
//        }

//        public int TongSoHoaDon()
//        {
//            string collectionName = "HoaDon";
//            return db.CountDocuments(collectionName, new BsonDocument());
//        }

//        public float DoanhThuNgay()
//        {
//            string collectionName = "HoaDon";
//            var today = DateTime.Now.Date;
//            var filter = Builders<BsonDocument>.Filter.Eq("Ngay", today);

//            var aggregate = db.Aggregate(collectionName, new[]
//            {
//                new BsonDocument("$match", filter.ToBsonDocument()),
//                new BsonDocument("$group", new BsonDocument
//                {
//                    { "_id", BsonNull.Value },
//                    { "TongTien", new BsonDocument("$sum", "$TongTien") }
//                })
//            });

//            var result = aggregate.FirstOrDefault();
//            return result == null ? 0 : result["TongTien"].ToDouble();
//        }

//        public float TongDoanhThu()
//        {
//            string collectionName = "HoaDon";

//            var aggregate = db.Aggregate(collectionName, new[]
//            {
//                new BsonDocument("$group", new BsonDocument
//                {
//                    { "_id", BsonNull.Value },
//                    { "TongTien", new BsonDocument("$sum", "$TongTien") }
//                })
//            });

//            var result = aggregate.FirstOrDefault();
//            return result == null ? 0 : result["TongTien"].ToDouble();
//        }

//        public string BestSeller()
//        {
//            string detailCollection = "ChiTietHoaDon";
//            string itemCollection = "Mon";

//            var aggregate = db.Aggregate(detailCollection, new[]
//            {
//                new BsonDocument("$group", new BsonDocument
//                {
//                    { "_id", "$MaMon" },
//                    { "TongSoLuong", new BsonDocument("$sum", "$SoLuong") }
//                }),
//                new BsonDocument("$sort", new BsonDocument("TongSoLuong", -1)),
//                new BsonDocument("$limit", 1)
//            });

//            var result = aggregate.FirstOrDefault();
//            if (result != null)
//            {
//                var maMon = result["_id"].ToString();
//                var filter = Builders<BsonDocument>.Filter.Eq("MaMon", maMon);
//                var mon = db.FindOne(itemCollection, filter);
//                return mon?["TenMon"].AsString ?? "Không có";
//            }

//            return "Không có";
//        }
//    }
//}
