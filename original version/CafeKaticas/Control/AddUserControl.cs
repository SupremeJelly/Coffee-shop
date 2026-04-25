using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DataTable BangNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            DataTable dt = db.Execute(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên!");
            }
            return dt;
        }

        public bool CheckUserName(string name)
        {
            string query = $"SELECT TaiKhoan FROM NhanVien WHERE TaiKhoan = '{name}'";
            DataTable dt = db.Execute(query);
            if(dt.Rows.Count == 0) { return false; }
            return true;
        }

        public void AddUser(string id, string usname, string password, string name, string role, string status, DateTime date)
        {
            string addquery = $"INSERT INTO NhanVien(id,TaiKhoan, MatKhau, HoTen, ChucVu, TrangThai, NgayVaoLam)" +
                              $"VALUE('{id}','{usname}','{password}', N'{name}',N'{role}',N'{status}','{date}')";
            db.ExecuteNonQuery(addquery);
        }

        public void UpdateUser(string usname, string password, string name, string role, string status, DateTime date)
        {
            string addquery = $"UPSATE NhanVien SET TaiKhoan = '{usname}', MatKhau = '{password}', HoTen = N'{name}',ChucVu = N'{role}', TrangThai = N'{status}', NgayVaoLam = '{date}' WHERE TaiKhoan = '{name}')";
            
            db.ExecuteNonQuery(addquery);
        }

        public void DeleteUser(string id)
        {
            string deletequery = $"DELETE FROM NhanVien WHERE id = '{id}'";

            db.ExecuteNonQuery(deletequery);
        }
    }
}
