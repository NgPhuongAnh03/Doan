using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1
{
    public partial class Thongke_Baocao : Form
    {
        public Thongke_Baocao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbThongKe.Text.Trim() == "Theo hóa đơn bán")
            {

                DTO_Hoadonban hd1 = new DTO_Hoadonban();
                DTO_Hoadonban hd2 = new DTO_Hoadonban();
                hd1.NgayBan = dtpDayStart.Value;
                hd2.NgayBan = dtpDayEnd.Value;
                if (bustk.LoadHoaDonBan(hd1, hd2).Rows.Count == 0)
                {
                    MessageBox.Show("Không thấy dữ liệu trong khoảng thời gian được chỉ định !", "Thông báo", MessageBoxButtons.OK); return;
                }
                dgvDanhSach.DataSource = bustk.LoadHoaDonBan(hd1, hd2);
                txtTong.Text = bustk.SumHDB_theongay(hd1, hd2).ToString();
            }
            if (cbbThongKe.Text.Trim() == "Theo hóa đơn nhập")
            {

                DTO_HoaDonNhap hd1 = new DTO_HoaDonNhap();
                DTO_HoaDonNhap hd2 = new DTO_HoaDonNhap();
                hd1.NgayNhap = dtpDayStart.Value;
                hd2.NgayNhap = dtpDayEnd.Value;
                if (bustk.LoadHoaDonNhap(hd1, hd2).Rows.Count == 0)
                {
                    MessageBox.Show("Không thấy dữ liệu trong khoảng thời gian được chỉ định !", "Thông báo", MessageBoxButtons.OK); return;
                }
                dgvDanhSach.DataSource = bustk.LoadHoaDonNhap(hd1, hd2);
                txtTong.Text = bustk.SumHDN_theongay(hd1, hd2).ToString();
            }
        }
    }
}
