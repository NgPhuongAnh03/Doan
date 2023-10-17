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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == "") || (txtPass.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo");
            }
            else
            {
                if ((txtUser.Text == "Admin") && (txtPass.Text == "123"))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    Dangnhap dn = new Dangnhap();
                    dn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập không thành công", "Thông báo");
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
