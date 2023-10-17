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
using BUS;

namespace DA1
{
    public partial class Nhacungcap : Form
    {
        BUS_Nhacungcap busnhacungcap = new BUS_Nhacungcap();
        public Nhacungcap()
        {
            InitializeComponent();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN1DataSet6.Nhacungcap' table. You can move, or remove it, as needed.
           // this.nhacungcapTableAdapter.Fill(this.dOAN1DataSet6.Nhacungcap);
            dgvChitietncc.DataSource = busnhacungcap.getDAL_NhaCungCap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            DTO_Nhacungcap ncc = new DTO_Nhacungcap(maNCC, tenNCC, diachi, sdt);

            if (busnhacungcap.kiemtramatrung(maNCC) == 1)
            {
                MessageBox.Show("Đã tồn tại mã nhà cung cấp!");
            }
            else
            {
                if (busnhacungcap.themNCC(ncc) == true)
                {
                    MessageBox.Show("Đã thêm nhà cung cấp mới", "Thông báo");
                    dgvChitietncc.DataSource = busnhacungcap.getDAL_NhaCungCap();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;

            DTO_Nhacungcap ncc = new DTO_Nhacungcap(maNCC, tenNCC, diaChi, sdt);
            if (busnhacungcap.suaNCC(ncc) == true)
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                dgvChitietncc.DataSource = busnhacungcap.getDAL_NhaCungCap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSDT.Text;

            DTO_Nhacungcap ncc = new DTO_Nhacungcap(maNCC, tenNCC, diachi, sdt);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busnhacungcap.xoaNCC(ncc) == true)
                {
                    MessageBox.Show("Xóa thông tin nhà cung cấp thành công", "Thông báo");
                    dgvChitietncc.DataSource = busnhacungcap.getDAL_NhaCungCap();
                }
            }
        }

        private void dgvChitietncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChitietncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNCC.Text = dgvChitietncc[0, i].Value.ToString();
            txtTenNCC.Text = dgvChitietncc[1, i].Value.ToString();
            txtDiachi.Text = dgvChitietncc[2, i].Value.ToString();
            txtSDT.Text = dgvChitietncc[3, i].Value.ToString();
            txtMaNCC.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiemMaNCC.Text.Trim() == "" && txtTimkiemTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DataTable result = new DataTable();
            if (txtTimkiemMaNCC.Text.Trim() != "" && txtTimkiemTenNCC.Text.Trim() == "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "MaNCC", "*" + txtTimkiemMaNCC.Text + "*");
                (dgvChitietncc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietncc.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhà cung cấp với mã nhà cung cấp này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (txtTimkiemMaNCC.Text.Trim() == "" && txtTimkiemTenNCC.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenNCC", "*" + txtTimkiemTenNCC.Text + "*");
                (dgvChitietncc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietncc.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhà cung cấp với tên nhà cung cấp này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietncc.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTimkiemMaNCC.Text.Trim() != "" && txtTimkiemTenNCC.Text.Trim() != "")
            {
                string rowFilter = string.Format("{0} like '{1}' OR {2} like '{3}'", "MaNCC", "*" + txtTimkiemMaNCC.Text + "*", "TenNCC", "*" + txtTimkiemTenNCC.Text + "*");
                (dgvChitietncc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                result = (dgvChitietncc.DataSource as DataTable).DefaultView.ToTable();

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhà cung cấp với mã và tên nhà cung cấp này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (dgvChitietncc.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void load()
        {
            dgvChitietncc.DataSource = busnhacungcap.getDAL_NhaCungCap();
            dgvChitietncc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvChitietncc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvChitietncc.Columns[2].HeaderText = "Số điện thoại";
            dgvChitietncc.Columns[3].HeaderText = "Địa chỉ";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {

        }
    }
}
