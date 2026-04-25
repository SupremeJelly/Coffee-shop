using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    class NhaCungCapControl
    {
        Database db;

        public NhaCungCapControl()
        {
            db = new Database();
        }

        public DataTable DSNhaCungCap()
        {
            string query = "SELECT * FROM NhaCungCap";
            DataTable dt = db.Execute(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhà cung cấp!");
            }
            return dt;
        }

        public DataTable TimKiemNCC(string timkiem)
        {
            string query = $"SELECT * FROM NhaCungCap WHERE MaNCC = '{timkiem}'";
            DataTable dt = db.Execute(query);
            return dt;
        }

        public void AddNCC(string id, string name, string address, string number, string email, string status)
        {
            string addquery = $"INSERT INTO NhaCungCap(MaNCC,Ten, DiaChi,SDT ,Email, TrangThai )" +
                $"VALUES('{id}',N'{name}',N'{address}','{number}','{email}',N'{status}')";
            db.ExecuteNonQuery(addquery);
        }
        public void UpdateNCC(string id, string name, string address, string number, string email, string status)
        {
            string addquery = $"UPDATE NhaCungCap SET MaNCC = '{id}', Ten = N'{name}', DiaChi = N'{address}', SDT = '{number}', Email ='{email}', TrangThai = N'{status}' WHERE MaNCC = N'{id}'";
            db.ExecuteNonQuery(addquery);
        }
    }
}
