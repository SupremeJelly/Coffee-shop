using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;

namespace CafeKaticas
{
    class NhapHangControl
    {
        Database db = new Database();

        public List<BsonDocument> NhapHang()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("TrangThai", "Đang xử lý");
            return db.Find("DonDatHang", filter);
        }

        public List<BsonDocument> TimKiem(DateTime timkiem)
        {
            var ngaydat = timkiem.ToString("yyyy-MM-dd");
            var filter = Builders<BsonDocument>.Filter.Eq("NgayDat", ngaydat);
            return db.Find("DonDatHang", filter);
        }
    }
}
