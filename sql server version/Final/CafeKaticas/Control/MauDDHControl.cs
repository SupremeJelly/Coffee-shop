using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CafeKaticas
{
    class MauDDHControl
    {
        private Database db;

        public MauDDHControl()
        {
            db = new Database();
        }

        public List<BsonDocument> DonDatHang(string maddh)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            return db.Find("DonDatHang", filter);
        }

        public List<BsonDocument> ChiTietDonDatHang(string maddh)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            return db.Find("ChiTietDonDatHang", filter);
        }

        public List<BsonDocument> NhaCungCap(string maddh)
        {
            var ddhFilter = Builders<BsonDocument>.Filter.Eq("MaDonDatHang", maddh);
            var ddh = db.Find("DonDatHang", ddhFilter).FirstOrDefault();
            if (ddh != null && ddh.Contains("MaNCC"))
            {
                string maNCC = ddh["MaNCC"].AsString;

                var nccFilter = Builders<BsonDocument>.Filter.Eq("MaNCC", maNCC);
                return db.Find("NhaCungCap", nccFilter);
            }

            return new List<BsonDocument>();
        }
    }
}
