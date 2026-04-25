using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string loginquery = $"SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = '{username}' AND MatKhau = '{password}' AND TrangThai = 'Da kich hoat'";
            if(db.IntExecuteScalar(loginquery) > 0)
            {
                return true;
            }
            return false;
        }

        public string GetRole(string username, string password)
        {
            string getrolequery = $"SELECT ChucVu FROM NhanVien WHERE TaiKhoan = '{username}' AND MatKhau = '{password}'";
            return db.StringExecuteScalar(getrolequery);
        }
    }
}
