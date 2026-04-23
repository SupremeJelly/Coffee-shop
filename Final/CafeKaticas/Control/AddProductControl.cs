using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CafeKaticas
{
    class AddProductControl
    {
        Database db;

        public AddProductControl()
        {
            db = new Database();
        }

        public List<BsonDocument> BangTonKho()
        {
            var filter = new BsonDocument();
            var results = db.Find("HangHoa", filter);
            if (results.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn kho!");
            }
            return results;
        }

        public bool CheckID(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", id);
            var result = db.Find("HangHoa", filter);
            return result.Count > 0;
        }

        public void AddProduct(string id, string name, int stock, string dvt, float price, string status)
        {
            var document = new BsonDocument
            {
                { "MaHang", id },
                { "TenHang", name },
                { "SoLuong", stock },
                { "DonViTinh", dvt },
                { "Gia", price },
                { "TrangThai", status }
            };
            db.Insert("HangHoa", document);
        }

        public void UpdateProduct(string id, string name, int stock, string dvt, float price, string status)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", id);
            var update = Builders<BsonDocument>.Update
                .Set("TenHang", name)
                .Set("SoLuong", stock)
                .Set("DonViTinh", dvt)
                .Set("Gia", price)
                .Set("TrangThai", status);
            db.Update("HangHoa", filter, update);
        }

        public void DeleteProduct(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", id);
            db.Delete("HangHoa", filter);
        }

        public List<string> OutOfStock()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("SoLuong", 0);
            var results = db.Find("HangHoa", filter);
            return results.Select(doc => doc["TenHang"].ToString()).ToList();
        }

        public void UpdateTonkho(string maHang, int soLuongNhap)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaHang", maHang);
            var update = Builders<BsonDocument>.Update.Inc("SoLuong", soLuongNhap);
            db.Update("HangHoa", filter, update);
        }
    }
}
