using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1
{
    public partial class Nhanvien : Form
    {
        BUS_Nhanvien busNhanvien = new BUS_Nhanvien();
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string gioitinh = txtGioitinh.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiachi.Text;

            DTO_Nhanvien nv = new DTO_Nhanvien(maNV, tenNV, gioitinh, sdt, diachi);

            if (busNhanvien.kiemtramatrung(maNV) == 1)
            {
                MessageBox.Show("Đã tồn tại mã nhân viên!");
            }
            else
            {
                if (busNhanvien.themNV(nv) == true)
                {
                    MessageBox.Show("Đã thêm nhân viên mới", "Thông báo");
                    dgvChitietnhanvien.DataSource = busNhanvien.getDAL_Nhanvien();
                }
            }
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN1DataSet1.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.dOAN1DataSet1.Nhanvien);
            dgvChitietnhanvien.DataSource = busNhanvien.getDAL_Nhanvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string gioitinh = txtGioitinh.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiachi.Text;

            DTO_Nhanvien nv = new DTO_Nhanvien(maNV, tenNV, gioitinh, sdt, diachi);

            if (busNhanvien.suaNV(nv) == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                dgvChitietnhanvien.DataSource = busNhanvien.getDAL_Nhanvien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string gioitinh = txtGioitinh.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiachi.Text;

            DTO_Nhanvien nv = new DTO_Nhanvien(maNV, tenNV, gioitinh, sdt, diachi);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busNhanvien.xoaNV(nv) == true)
                {
                    MessageBox.Show("Xóa thông tin nhân viên thành công", "Thông báo");
                    dgvChitietnhanvien.DataSource = busNhanvien.getDAL_Nhanvien();
                }
            }
        }

        private void dgvChitietnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNV.Text = dgvChitietnhanvien[0, i].Value.ToString();
            txtTenNV.Text = dgvChitietnhanvien[1, i].Value.ToString();
            txtSDT.Text = dgvChitietnhanvien[2, i].Value.ToString();
            txtGioitinh.Text = dgvChitietnhanvien[3, i].Value.ToString();
            txtDiachi.Text = dgvChitietnhanvien[4, i].Value.ToString();
            txtMaNV.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiemMaNV.Text.Trim() == "" && txtTimkiemTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DataTable result = new DataTable();
            if (txtTimkiemMaNV.Text.Trim() != "" && txtTimkiemTenNV.Text.Trim() == "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "MaNV", "*" + txtTimkiemMaNV.Text + "*");
                (dgvChitietnhanvien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietnhanvien.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên với mã nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (txtTimkiemMaNV.Text.Trim() == "" && txtTimkiemTenNV.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenNV", "*" + txtTimkiemTenNV.Text + "*");
                (dgvChitietnhanvien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietnhanvien.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên với tên nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietnhanvien.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTimkiemMaNV.Text.Trim() != "" && txtTimkiemTenNV.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}' OR {2} like '{3}'", "MaNV", "*" + txtTimkiemMaNV.Text + "*", "TenNV", "*" + txtTimkiemTenNV.Text + "*");
                (dgvChitietnhanvien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietnhanvien.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên với mã và tên nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietnhanvien.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void load()
        {
            dgvChitietnhanvien.DataSource = busNhanvien.getDAL_Nhanvien();
            dgvChitietnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvChitietnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvChitietnhanvien.Columns[2].HeaderText = "Giới tính";
            dgvChitietnhanvien.Columns[3].HeaderText = "Số điện thoại";
            dgvChitietnhanvien.Columns[4].HeaderText = "Địa chỉ";
        }
    }
}
