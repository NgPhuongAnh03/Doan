namespace DA1
{
    partial class Sanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimkiemTenSP = new System.Windows.Forms.TextBox();
            this.txtTimkiemMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChitietsanpham = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAN1DataSet = new DA1.DOAN1DataSet();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnNhacungcap = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.sanphamTableAdapter = new DA1.DOAN1DataSetTableAdapters.SanphamTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(439, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(571, 57);
            this.label9.TabIndex = 77;
            this.label9.Text = "WELCOME TO KIDS SHOP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtGiaban);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(283, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 553);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimkiemTenSP);
            this.groupBox3.Controls.Add(this.txtTimkiemMaSP);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnTimkiem);
            this.groupBox3.Location = new System.Drawing.Point(19, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(856, 135);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimkiemTenSP
            // 
            this.txtTimkiemTenSP.Location = new System.Drawing.Point(274, 88);
            this.txtTimkiemTenSP.Name = "txtTimkiemTenSP";
            this.txtTimkiemTenSP.Size = new System.Drawing.Size(220, 29);
            this.txtTimkiemTenSP.TabIndex = 41;
            // 
            // txtTimkiemMaSP
            // 
            this.txtTimkiemMaSP.Location = new System.Drawing.Point(274, 38);
            this.txtTimkiemMaSP.Name = "txtTimkiemMaSP";
            this.txtTimkiemMaSP.Size = new System.Drawing.Size(220, 29);
            this.txtTimkiemMaSP.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã sản phẩm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(556, 63);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(119, 40);
            this.btnTimkiem.TabIndex = 37;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(166, 134);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(220, 29);
            this.txtMaNCC.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChitietsanpham);
            this.groupBox2.Location = new System.Drawing.Point(6, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 231);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // dgvChitietsanpham
            // 
            this.dgvChitietsanpham.AutoGenerateColumns = false;
            this.dgvChitietsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn});
            this.dgvChitietsanpham.DataSource = this.sanphamBindingSource;
            this.dgvChitietsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChitietsanpham.Location = new System.Drawing.Point(3, 25);
            this.dgvChitietsanpham.Name = "dgvChitietsanpham";
            this.dgvChitietsanpham.Size = new System.Drawing.Size(875, 203);
            this.dgvChitietsanpham.TabIndex = 0;
            this.dgvChitietsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietsanpham_CellClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "Giaban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giaban";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "Sanpham";
            this.sanphamBindingSource.DataSource = this.dOAN1DataSet;
            // 
            // dOAN1DataSet
            // 
            this.dOAN1DataSet.DataSetName = "DOAN1DataSet";
            this.dOAN1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(774, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 33);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(774, 74);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 33);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(774, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 33);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(517, 33);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(220, 29);
            this.txtSize.TabIndex = 11;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(517, 130);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(220, 29);
            this.txtGiaban.TabIndex = 10;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(517, 79);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(220, 29);
            this.txtSoluong.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(166, 83);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(220, 29);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(166, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(220, 29);
            this.txtMaSP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 122);
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(40, 577);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(203, 42);
            this.btnThoat.TabIndex = 84;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.Black;
            this.btnThongke.Location = new System.Drawing.Point(40, 507);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(203, 42);
            this.btnThongke.TabIndex = 83;
            this.btnThongke.Text = "Thống kê ";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // btnHoadon
            // 
            this.btnHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.Color.Black;
            this.btnHoadon.Location = new System.Drawing.Point(40, 437);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(203, 42);
            this.btnHoadon.TabIndex = 82;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = true;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanvien.Location = new System.Drawing.Point(40, 365);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(203, 42);
            this.btnNhanvien.TabIndex = 81;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            // 
            // btnNhacungcap
            // 
            this.btnNhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhacungcap.ForeColor = System.Drawing.Color.Black;
            this.btnNhacungcap.Location = new System.Drawing.Point(40, 294);
            this.btnNhacungcap.Name = "btnNhacungcap";
            this.btnNhacungcap.Size = new System.Drawing.Size(203, 42);
            this.btnNhacungcap.TabIndex = 80;
            this.btnNhacungcap.Text = "Nhà Cung Cấp";
            this.btnNhacungcap.UseVisualStyleBackColor = true;
            // 
            // btnSanpham
            // 
            this.btnSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.ForeColor = System.Drawing.Color.Black;
            this.btnSanpham.Location = new System.Drawing.Point(40, 224);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(203, 42);
            this.btnSanpham.TabIndex = 79;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangchu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangchu.Location = new System.Drawing.Point(40, 158);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(203, 42);
            this.btnTrangchu.TabIndex = 78;
            this.btnTrangchu.Text = "Trang chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1217, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnHoadon);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnNhacungcap);
            this.Controls.Add(this.btnSanpham);
            this.Controls.Add(this.btnTrangchu);
            this.Name = "Sanpham";
            this.Text = "Sanpham";
            this.Load += new System.EventHandler(this.Sanpham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimkiemTenSP;
        private System.Windows.Forms.TextBox txtTimkiemMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChitietsanpham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnNhacungcap;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnTrangchu;
        private DOAN1DataSet dOAN1DataSet;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private DOAN1DataSetTableAdapters.SanphamTableAdapter sanphamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
    }
}