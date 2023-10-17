using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DA1
{
    public partial class Hoadonnhap : Form
    {
        BUS_ChitietHDN busChitietHDN = new BUS_ChitietHDN();
        BUS_Hoadonnhap busHoadonnhap = new BUS_Hoadonnhap();
        BUS_Sanpham busSanpham = new BUS_Sanpham();
        public Hoadonnhap()
        {
            InitializeComponent();
        }

        private void Hoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN1DataSet3.ChitietHDN' table. You can move, or remove it, as needed.
            this.chitietHDNTableAdapter.Fill(this.dOAN1DataSet3.ChitietHDN);
            // TODO: This line of code loads data into the 'dOAN1DataSet3.ChitietHDN' table. You can move, or remove it, as needed.
            this.chitietHDNTableAdapter.Fill(this.dOAN1DataSet3.ChitietHDN);
            dgvDSHDN.DataSource = busChitietHDN.getChitietHDN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTHDN = txtMachitietHDN.Text;
            DateTime ngaynhap= DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            string maHDN = txtMaHDN.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien= (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));

            DTO_ChitietHDN cthdn = new DTO_ChitietHDN(maCTHDN, maHDN, maNV, maSP, soluong, dongia, thanhtien, ngaynhap);
            DTO_Hoadonnhap hdn = new DTO_Hoadonnhap(maHDN, maNV, ngaynhap, thanhtien);
            if (busHoadonnhap.kiemtramatrung(maCTHDN) == 1)
            {
                MessageBox.Show("Mã hóa đơn bạn nhập bị trùng!", "Thông báo");
            }
            else
            {
                if (busHoadonnhap.themHDN(hdn) == true && busChitietHDN.themChitietHDN(cthdn) == true)
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    dgvDSHDN.DataSource = busChitietHDN.getChitietHDN();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTHDN = txtMachitietHDN.Text;
            DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            string maHDN = txtMaHDN.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien = (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));

            DTO_ChitietHDN cthdn = new DTO_ChitietHDN(maCTHDN, maHDN, maNV, maSP, soluong, dongia, thanhtien, ngaynhap);
            DTO_Hoadonnhap hdn = new DTO_Hoadonnhap(maHDN, maNV, ngaynhap, thanhtien);
            if (busHoadonnhap.suaHDN(hdn) == true && busChitietHDN.suaChitietHDN(cthdn) == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                dgvDSHDN.DataSource = busChitietHDN.getChitietHDN();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCTHDN = txtMachitietHDN.Text;
            DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            string maHDN = txtMaHDN.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien = (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));

            DTO_ChitietHDN cthdn = new DTO_ChitietHDN(maCTHDN, maHDN, maNV, maSP, soluong, dongia, thanhtien, ngaynhap);
            DTO_Hoadonnhap hdn = new DTO_Hoadonnhap(maHDN, maNV, ngaynhap, thanhtien);
            hdn.MaHDN = txtMaHDN.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHoadonnhap.xoaHDN(hdn) == true)
                {
                    MessageBox.Show("Xóa thông tin hóa đơn thành công", "Thông báo");
                    dgvDSHDN.DataSource = busChitietHDN.getChitietHDN();
                }
            }
        }

        private void dgvDSHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sp = e.RowIndex;
            txtMaHDN.Text= dgvDSHDN[0, sp].Value.ToString();
            cbbMaNV.Text = dgvDSHDN[1, sp].Value.ToString();
            dtpNgayNhap.Text = dgvDSHDN[2, sp].Value.ToString();
            txtMachitietHDN.Text = dgvDSHDN[3, sp].Value.ToString();
            cbbMaSP.Text = dgvDSHDN[4, sp].Value.ToString();
            txtSoluong.Text = dgvDSHDN[5, sp].Value.ToString();
            txtDongia.Text = dgvDSHDN[6, sp].Value.ToString();
            lblThanhtien.Text = dgvDSHDN[7, sp].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiemMaHDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DataTable result = new DataTable();
            if (txtTimkiemMaHDN.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "MaHDB", "*" + txtTimkiemMaHDN.Text + "*");
                (dgvDSHDN.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvDSHDN.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin hóa đơn với mã hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tìm kiếm hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
