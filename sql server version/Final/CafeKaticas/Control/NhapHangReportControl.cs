using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;

namespace CafeKaticas
{
    class NhapHangReportControl
    {
        private Database db;

        public NhapHangReportControl()
        {
            db = new Database();
        }

        public List<BsonDocument> Report(string maddh)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            return db.Find("ChiTietDonDatHang", filter);
        }
    }
}
