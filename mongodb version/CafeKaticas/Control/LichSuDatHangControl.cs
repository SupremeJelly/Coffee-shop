using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CafeKaticas
{
    class LichSuDatHangControl
    {
        private Database db = new Database();

        public List<BsonDocument> LichSuDatHang()
        {
            return db.GetAll("DonDatHang");
        }

        public List<string> NCC()
        {
            var documents = db.GetAll("NhaCungCap");
            return documents
                .Select(doc => doc["MaNCC"].AsString)
                .Distinct()
                .ToList();
        }

        public List<BsonDocument> DonDatHang(string ncc, string tt)
        {
            var collection = db.GetCollection("DonDatHang");
            var filterBuilder = Builders<BsonDocument>.Filter;
            var filters = new List<FilterDefinition<BsonDocument>>();

            if (!string.IsNullOrEmpty(ncc))
            {
                filters.Add(filterBuilder.Eq("MaNhaCC", ncc));
            }

            if (!string.IsNullOrEmpty(tt))
            {
                filters.Add(filterBuilder.Eq("TrangThai", tt));
            }

            var filter = filters.Count > 0 ? filterBuilder.And(filters) : FilterDefinition<BsonDocument>.Empty;
            return collection.Find(filter).ToList();
        }
    }
}
