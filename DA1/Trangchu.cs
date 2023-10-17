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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sanpham frm1 = new Sanpham();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhacungcap frm2 = new Nhacungcap();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhanvien frm3 = new Nhanvien();
            frm3.ShowDialog();
            frm3 = null;
            this.Show();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadonnhap frm4 = new Hoadonnhap();
            frm4.ShowDialog();
            frm4 = null;
            this.Show();
            this.Hide();
            Hoadonban frm5 = new Hoadonban();
            frm5.ShowDialog();
            frm5 = null;
            this.Show();
        }
    }
}
