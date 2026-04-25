using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    public partial class LichSuBanHang : UserControl
    {
        LichSuBanHangControl lsbh = new LichSuBanHangControl();
        public string maddh;

        public LichSuBanHang()
        {
            InitializeComponent();
            ShowDGV();
            displayKhachHangData();
            
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayKhachHangData();
        }

        public void ShowDGV()
        {
            dgvHoaDon.Columns.Clear();
            dgvHoaDon.Columns.Add("STT", "STT");
            dgvHoaDon.Columns.Add("MaHoaDon", "Mã hóa đơn");
            dgvHoaDon.Columns.Add("Ngay", "Ngày");
            dgvHoaDon.Columns.Add("TienNhan", "Tiền nhận");
            dgvHoaDon.Columns.Add("TienThua", "Tiền thừa");
            dgvHoaDon.Columns.Add("TongTien", "Tổng tiền");
        }

        public void displayKhachHangData()
        {
            dgvHoaDon.Rows.Clear();

            DataTable dt = lsbh.LichSu();
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                dgvHoaDon.Rows.Add(i, dr["MaHoaDon"], dr["Ngay"], dr["TienNhan"], dr["TienThua"], dr["TongTien"]);
                i++;
            }
        }


    }
}
