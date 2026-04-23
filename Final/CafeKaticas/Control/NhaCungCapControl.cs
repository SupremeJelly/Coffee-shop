using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CafeKaticas
{
    class NhaCungCapControl
    {
        private Database db;

        public NhaCungCapControl()
        {
            db = new Database();
        }

        public List<BsonDocument> DSNhaCungCap()
        {
            return db.GetAll("NhaCungCap"); // Lấy toàn bộ dữ liệu từ collection
        }

        public void AddNCC(string id, string name, string address, string number, string email, string status)
        {
            var document = new BsonDocument
            {
                { "MaNCC", id },
                { "Ten", name },
                { "DiaChi", address },
                { "SDT", number },
                { "Email", email },
                { "TrangThai", status }
            };
            db.Insert("NhaCungCap", document);
        }

        public void UpdateNCC(string id, string name, string address, string number, string email, string status)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaNCC", id);
            var update = Builders<BsonDocument>.Update
                .Set("Ten", name)
                .Set("DiaChi", address)
                .Set("SDT", number)
                .Set("Email", email)
                .Set("TrangThai", status);

            db.Update("NhaCungCap", filter, update);
        }

        public List<BsonDocument> SearchNCC(string keyword)
        {
            var filter = Builders<BsonDocument>.Filter.Or(
                Builders<BsonDocument>.Filter.Regex("MaNCC", new BsonRegularExpression(keyword, "i")),
                Builders<BsonDocument>.Filter.Regex("Ten", new BsonRegularExpression(keyword, "i"))
            );

            return db.Find("NhaCungCap", filter);
        }
    }
}
