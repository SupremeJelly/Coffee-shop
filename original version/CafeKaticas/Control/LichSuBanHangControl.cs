using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKaticas
{
    class LichSuBanHangControl
    {
        Database db = new Database();

        public DataTable LichSu()
        {
            string query = @"SELECT * FROM HoaDon";
            DataTable dt = db.Execute(query);
            return dt;
        }

       
    }
}
