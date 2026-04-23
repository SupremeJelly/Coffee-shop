using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace CafeKaticas
{
    class LogInControl
    {
        Database db;

        public LogInControl()
        {
            db = new Database();
        }

        public bool LogIn(string username, string password)
        {
            var collection = db.GetCollection("NhanVien");
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoan", username) &
                         Builders<BsonDocument>.Filter.Eq("MatKhau", password) &
                         Builders<BsonDocument>.Filter.Eq("TrangThai", "Da kich hoat");

            var result = collection.Find(filter).FirstOrDefault();

            if (result == null)
            {
                Console.WriteLine("Không tìm thấy kết quả phù hợp.");
            }
            else
            {
                Console.WriteLine("Tìm thấy kết quả.");
            }

            return result != null;
        }

        public string GetRole(string username, string password)
        {
            var collection = db.GetCollection("NhanVien");
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoan", username) &
                         Builders<BsonDocument>.Filter.Eq("MatKhau", password);

            var result = collection.Find(filter).FirstOrDefault();
            if (result != null)
            {
                return result["ChucVu"].AsString;
            }
            return string.Empty;
        }
    }
}

