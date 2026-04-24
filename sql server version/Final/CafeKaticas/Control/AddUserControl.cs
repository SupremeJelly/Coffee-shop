using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CafeKaticas
{
    class AddUserControl
    {
        Database db;

        public AddUserControl()
        {
            db = new Database();
        }

        public List<BsonDocument> GetAllUsers()
        {
            return db.GetAll("NhanVien");
        }

        public bool CheckUserName(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoan", username);
            var result = db.Find("NhanVien", filter);
            return result.Any();
        }

        public bool CheckID(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("id", id);
            var result = db.Find("NhanVien", filter);
            return result.Any();
        }

        public void AddUser(string id, string username, string password, string name, string role, string status, DateTime date)
        {
            var document = new BsonDocument
            {
                { "id", id },
                { "TaiKhoan", username },
                { "MatKhau", password },
                { "HoTen", name },
                { "ChucVu", role },
                { "TrangThai", status },
                { "NgayVaoLam", date }
            };
            db.Insert("NhanVien", document);
        }

        public void UpdateUser(string id, string username, string password, string name, string role, string status, DateTime date)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("id", id);
            var update = Builders<BsonDocument>.Update
                .Set("TaiKhoan", username)
                .Set("MatKhau", password)
                .Set("HoTen", name)
                .Set("ChucVu", role)
                .Set("TrangThai", status)
                .Set("NgayVaoLam", date);
            db.Update("NhanVien", filter, update);
        }

        public void DeleteUser(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("id", id);
            db.Delete("NhanVien", filter);
        }
    }
}
