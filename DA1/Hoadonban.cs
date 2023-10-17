using BUS;
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
    public partial class Hoadonban : Form
    {
        BUS_ChitietHDB busChitietHDB = new BUS_ChitietHDB();
        BUS_Hoadonban busHoadonban = new BUS_Hoadonban();
        BUS_Sanpham busSanpham = new BUS_Sanpham();
        public Hoadonban()
        {
            InitializeComponent();
        }

        private void Hoadonban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN1DataSet4.ChitietHDB' table. You can move, or remove it, as needed.
            this.chitietHDBTableAdapter.Fill(this.dOAN1DataSet4.ChitietHDB);
            dgvDSHDB.DataSource = busChitietHDB.getChitietHDB();
        }

        private void btnThem(object sender, EventArgs e)
        {
            string maCTHDB = txtMachitietHDB.Text;
            DateTime ngayban = DateTime.Parse(dtpNgayban.Value.ToShortDateString());
            string maHDB = txtMaHDB.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien = (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));

            DTO_ChitietHDB cthdb = new DTO_ChitietHDB(maCTHDB, maHDB, maNV, maSP, soluong, dongia, thanhtien, ngayban);
            DTO_Hoadonban hdb = new DTO_Hoadonban(maHDB, maNV, ngayban, thanhtien);
            if (busHoadonban.kiemtramatrung(maCTHDB) == 1)
            {
                MessageBox.Show("Mã hóa đơn bạn nhập bị trùng!", "Thông báo");
            }
            else
            {
                if (busHoadonban.themHDB(hdb) == true && busChitietHDB.themChitietHDB(cthdb) == true)
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    dgvDSHDB.DataSource = busChitietHDB.getChitietHDB();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTHDB = txtMachitietHDB.Text;
            DateTime ngayban = DateTime.Parse(dtpNgayban.Value.ToShortDateString());
            string maHDB = txtMaHDB.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien = (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));

            DTO_ChitietHDB cthdb = new DTO_ChitietHDB(maCTHDB, maHDB, maNV, maSP, soluong, dongia, thanhtien, ngayban);
            DTO_Hoadonban hdb = new DTO_Hoadonban(maHDB, maNV, ngayban, thanhtien);
            if (busHoadonban.suaHDB(hdb) == true && busChitietHDB.suaChitietHDB(cthdb) == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                dgvDSHDB.DataSource = busChitietHDB.getChitietHDB();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCTHDB = txtMachitietHDB.Text;
            DateTime ngayban = DateTime.Parse(dtpNgayban.Value.ToShortDateString());
            string maHDB = txtMaHDB.Text;
            string maNV = cbbMaNV.Text;
            string maSP = cbbMaSP.Text;
            int soluong = int.Parse(txtSoluong.Text.Trim());
            float dongia = float.Parse(txtDongia.Text.Trim());
            float thanhtien = (soluong * dongia);
            lblThanhtien.Text = thanhtien.ToString();
            thanhtien = float.Parse(lblThanhtien.Text.Replace(",", ""));
            DTO_ChitietHDB cthdb = new DTO_ChitietHDB(maCTHDB, maHDB, maNV, maSP, soluong, dongia, thanhtien, ngayban);
            DTO_Hoadonban hdb = new DTO_Hoadonban(maHDB, maNV, ngayban, thanhtien);
            hdb.MaHDB = txtMaHDB.Text;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busHoadonban.xoaHDB(hdb) == true)
                {
                    MessageBox.Show("Xóa thông tin hóa đơn thành công", "Thông báo");
                    dgvDSHDB.DataSource = busChitietHDB.getChitietHDB();
                }
            }
        }

        private void dgvDSHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sp = e.RowIndex;
            txtMaHDB.Text = dgvDSHDB[0, sp].Value.ToString();
            cbbMaNV.Text = dgvDSHDB[1, sp].Value.ToString();
            dtpNgayban.Text = dgvDSHDB[2, sp].Value.ToString();
            txtMachitietHDB.Text = dgvDSHDB[3, sp].Value.ToString();
            cbbMaSP.Text = dgvDSHDB[4, sp].Value.ToString();
            txtSoluong.Text = dgvDSHDB[5, sp].Value.ToString();
            txtDongia.Text = dgvDSHDB[6, sp].Value.ToString();
            lblThanhtien.Text = dgvDSHDB[7, sp].Value.ToString();
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
                (dgvDSHDB.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvDSHDB.DataSource as DataTable).DefaultView.ToTable();

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
