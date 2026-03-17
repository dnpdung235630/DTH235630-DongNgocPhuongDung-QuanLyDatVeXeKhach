namespace QuanLyDatVeXeKhach.Forms
{
    partial class frmChuyenXe
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaXe = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            cboTuyenXe = new ComboBox();
            label2 = new Label();
            cboTaiXe = new ComboBox();
            cboNhanVienPhuTrach = new ComboBox();
            label3 = new Label();
            cboDichVu = new ComboBox();
            label6 = new Label();
            numGiaVe = new NumericUpDown();
            label7 = new Label();
            txtGioKhoiHanh = new TextBox();
            dtpNgayKhoiHanh = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaVe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(15, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1363, 343);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chuyến xe";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1357, 317);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 59);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tuyến xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 59);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Biển số xe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 119);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 4;
            label5.Text = "Nhân viên phụ trách";
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(166, 52);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(150, 27);
            txtMaXe.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(978, 58);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(978, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(978, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1104, 58);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1104, 116);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1104, 178);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1236, 59);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1236, 117);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1236, 179);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // cboTuyenXe
            // 
            cboTuyenXe.FormattingEnabled = true;
            cboTuyenXe.Location = new Point(490, 51);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(346, 28);
            cboTuyenXe.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 24;
            label2.Text = "Tên tài xế";
            // 
            // cboTaiXe
            // 
            cboTaiXe.FormattingEnabled = true;
            cboTaiXe.Location = new Point(165, 116);
            cboTaiXe.Name = "cboTaiXe";
            cboTaiXe.Size = new Size(293, 28);
            cboTaiXe.TabIndex = 25;
            // 
            // cboNhanVienPhuTrach
            // 
            cboNhanVienPhuTrach.FormattingEnabled = true;
            cboNhanVienPhuTrach.Location = new Point(659, 116);
            cboNhanVienPhuTrach.Name = "cboNhanVienPhuTrach";
            cboNhanVienPhuTrach.Size = new Size(293, 28);
            cboNhanVienPhuTrach.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 178);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 27;
            label3.Text = "Dịch vụ";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(166, 175);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(292, 28);
            cboDichVu.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 178);
            label6.Name = "label6";
            label6.Size = new Size(200, 20);
            label6.TabIndex = 29;
            label6.Text = "Giá vé (thay đổi tùy loại ghế)";
            // 
            // numGiaVe
            // 
            numGiaVe.Location = new Point(711, 175);
            numGiaVe.Name = "numGiaVe";
            numGiaVe.Size = new Size(241, 27);
            numGiaVe.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 234);
            label7.Name = "label7";
            label7.Size = new Size(201, 20);
            label7.TabIndex = 31;
            label7.Text = "Ngày giờ khởi hành (dự kiến)";
            // 
            // txtGioKhoiHanh
            // 
            txtGioKhoiHanh.Location = new Point(467, 231);
            txtGioKhoiHanh.Name = "txtGioKhoiHanh";
            txtGioKhoiHanh.Size = new Size(125, 27);
            txtGioKhoiHanh.TabIndex = 32;
            // 
            // dtpNgayKhoiHanh
            // 
            dtpNgayKhoiHanh.Location = new Point(648, 231);
            dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            dtpNgayKhoiHanh.Size = new Size(250, 27);
            dtpNgayKhoiHanh.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayKhoiHanh);
            groupBox1.Controls.Add(txtGioKhoiHanh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numGiaVe);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboDichVu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboNhanVienPhuTrach);
            groupBox1.Controls.Add(cboTaiXe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboTuyenXe);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaXe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1363, 294);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // frmChuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 726);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChuyenXe";
            Text = "frmChuyenXe";
            Load += frmChuyenXe_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaVe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtMaXe;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private ComboBox cboTuyenXe;
        private Label label2;
        private ComboBox cboTaiXe;
        private ComboBox cboNhanVienPhuTrach;
        private Label label3;
        private ComboBox cboDichVu;
        private Label label6;
        private NumericUpDown numGiaVe;
        private Label label7;
        private TextBox txtGioKhoiHanh;
        private DateTimePicker dtpNgayKhoiHanh;
        private GroupBox groupBox1;
    }
}