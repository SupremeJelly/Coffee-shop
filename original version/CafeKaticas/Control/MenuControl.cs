using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class MenuControl
    {
        Database db;

        public MenuControl()
        {
            db = new Database();
        }

        public DataTable Menu()
        {
            string query = "SELECT * FROM Mon";
            DataTable dt = db.Execute(query);
            return dt;
        }

        public void AddMenu(string id, string name, string type, float price, string dvt, string nl, string status)
        {
            string query = $"INSERT INTO Mon(MaMon, TenMon, Loai, Gia, DonViTinh, NguyenLieu, TrangThai)" +
                           $"VALUES ('{id}',N'{name}',N'{type}','{price}',N'{dvt}',N'{nl}',N'{status}')";
            db.ExecuteNonQuery(query);
        }

        public void UpdateMenu(string id, string name, string type, float price, string dvt, string nl, string status)
        {
            string updatequery = $"UPDATE Mon SET TenMon = N'{name}', Loai = N'{type}', Gia = '{price}', DonViTinh = N'{dvt}', NguyenLieu = N'{nl}', TrangThai = N'{status}' WHERE MaMon = '{id}')";
            db.ExecuteNonQuery(updatequery);
        }

        public bool CheckId(string id)
        {
            string checkid = $"SELECT MaMon FROM Mon WHERE MaMon = '{id}'";
            DataTable dt = db.Execute(checkid);
            if (dt.Rows.Count == 0) { return false; }
            return true;
        }

        public bool CheckName(string name)
        {
            string checkname = $"SELECT TenMon FROM Mon WHERE TenMon = '{name}'";
            DataTable dt = db.Execute(checkname);
            if (dt.Rows.Count == 0) { return false; }
            return true;
        }

        public DataTable GetName()
        {
            string getname = "SELECT DISTINCT TenMon FROM Mon";
            DataTable dt = db.Execute(getname);
            return dt;
        }

        public DataTable GetNL()
        {
            string getNL = $"SELECT DISTINCT MaHang FROM HangHoa WHERE TrangThai = N'Đang bán'";
            DataTable dt = db.Execute(getNL);
            return dt;
        }

        public DataTable Search(string mon, string loai, string trangthai)
        {
            string query = "SELECT * FROM Mon";
            bool check = false;

            if (!string.IsNullOrEmpty(mon))
            {
                query += " WHERE TenMon = N'" + mon + "'";
                check = true;
            }

            if (!string.IsNullOrEmpty(loai))
            {
                if (check)
                {
                    query += " AND Loai = N'" + loai + "'";
                }
                else
                {
                    query += " WHERE Loai = N'" + loai + "'";
                    check = true;
                }
            }

            if (!string.IsNullOrEmpty(trangthai))
            {
                if (check)
                {
                    query += " AND TrangThai = N'" + trangthai + "'";
                }
                else
                {
                    query += " WHERE TrangThai = N'" + trangthai + "'";
                    check = true;
                }
            }

            DataTable dt = db.Execute(query);
            return dt;
        }

    }
}
