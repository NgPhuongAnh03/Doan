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
    public partial class Sanpham : Form
    {
        BUS_Sanpham busSanpham = new BUS_Sanpham();
        public Sanpham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string size = txtSize.Text;
            int soluong = int.Parse(txtSoluong.Text);
            float giaban = float.Parse(txtGiaban.Text);
            string maNCC = txtMaNCC.Text;

            DTO_Sanpham sp = new DTO_Sanpham(maSP, tenSP, size, soluong, giaban, maNCC);

            if (busSanpham.kiemtramatrung(maSP) == 1)
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm!");
            }
            else
            {
                if (busSanpham.themSP(sp) == true)
                {
                    MessageBox.Show("Đã thêm sản phẩm mới", "Thông báo");
                    dgvChitietsanpham.DataSource = busSanpham.getDAL_Sanpham();
                }
            }
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN1DataSet.Sanpham' table. You can move, or remove it, as needed.
            this.sanphamTableAdapter.Fill(this.dOAN1DataSet.Sanpham);
            dgvChitietsanpham.DataSource = busSanpham.getDAL_Sanpham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string size = txtSize.Text;
            int soluong = int.Parse(txtSoluong.Text);
            float giaban = float.Parse(txtGiaban.Text);
            string maNCC = txtMaNCC.Text;
            DTO_Sanpham sp = new DTO_Sanpham(maSP, tenSP, size, soluong, giaban, maNCC);

            if (busSanpham.suaSP(sp) == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                dgvChitietsanpham.DataSource = busSanpham.getDAL_Sanpham();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string size = txtSize.Text;
            int soluong = int.Parse(txtSoluong.Text);
            float giaban = float.Parse(txtGiaban.Text);
            string maNCC = txtMaNCC.Text;

            DTO_Sanpham sp = new DTO_Sanpham(maSP, tenSP, size, soluong, giaban, maNCC);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busSanpham.xoaSP(sp) == true)
                {
                    MessageBox.Show("Xóa thông tin sản phẩm thành công", "Thông báo");
                    dgvChitietsanpham.DataSource = busSanpham.getDAL_Sanpham();
                }
            }
        }

        private void dgvChitietsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaSP.Text = dgvChitietsanpham[0, i].Value.ToString();
            txtTenSP.Text = dgvChitietsanpham[1, i].Value.ToString();
            txtSize.Text = dgvChitietsanpham[2, i].Value.ToString();
            txtSoluong.Text = dgvChitietsanpham[3, i].Value.ToString();
            txtGiaban.Text = dgvChitietsanpham[4, i].Value.ToString();
            txtMaNCC.Text = dgvChitietsanpham[5, i].Value.ToString();
            txtMaSP.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiemMaSP.Text.Trim() == "" && txtTimkiemTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DataTable result = new DataTable();
            if (txtTimkiemMaSP.Text.Trim() != "" && txtTimkiemTenSP.Text.Trim() == "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "MaMH", "*" + txtTimkiemMaSP.Text + "*");
                (dgvChitietsanpham.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietsanpham.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm với mã sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (txtTimkiemMaSP.Text.Trim() == "" && txtTimkiemTenSP.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenSP", "*" + txtTimkiemTenSP.Text + "*");
                (dgvChitietsanpham.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietsanpham.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm với tên sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietsanpham.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTimkiemMaSP.Text.Trim() != "" && txtTimkiemTenSP.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}' OR {2} like '{3}'", "MaMH", "*" + txtTimkiemMaSP.Text + "*", "TenMH", "*" + txtTimkiemTenSP.Text + "*");
                (dgvChitietsanpham.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietsanpham.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin mô hình với mã và tên sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietsanpham.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void load()
        {
            dgvChitietsanpham.DataSource = busSanpham.getDAL_Sanpham();
            dgvChitietsanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvChitietsanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvChitietsanpham.Columns[2].HeaderText = "Size";
            dgvChitietsanpham.Columns[3].HeaderText = "Số lượng";
            dgvChitietsanpham.Columns[4].HeaderText = "Giá bán";
            dgvChitietsanpham.Columns[5].HeaderText = "Mã nhà cung cấp";
        }
    }
}
