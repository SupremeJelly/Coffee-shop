using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class LichSuDatHangControl
    {
        Database db = new Database();
        public DataTable LichSuDatHang()
        {
            string lsdh = "SELECT * FROM DonDatHang";
            DataTable dt = db.Execute(lsdh);
            return dt;
        }

        public DataTable NCC()
        {
            string ncc = "SELECT DISTINCT MaNCC FROM NhaCungCap";
            DataTable dt = db.Execute(ncc);
            return dt;
        }

        public DataTable DonDatHang(string ncc, string tt)
        {
            string ddh = $"SELECT * FROM DonDatHang";
            bool check = false;

            if (!string.IsNullOrEmpty(ncc))
            {
                    ddh += $" WHERE MaNhaCC = '"+ncc+"'";
                    check = true;                
            }

            if (!string.IsNullOrEmpty(tt))
            {
                if (check)
                {
                    ddh += $" AND TrangThai = N'"+tt+"'";
                }
                else
                {
                    ddh += $" WHERE TrangThai = N'"+tt+"'";
                    check = true;
                }
            }

            DataTable dt = db.Execute(ddh);
            return dt;
        }
    }
}
