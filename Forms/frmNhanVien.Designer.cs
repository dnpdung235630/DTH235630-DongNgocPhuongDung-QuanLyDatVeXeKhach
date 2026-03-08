namespace QuanLyDatVeXeKhach.Forms
{
    partial class frmNhanVien
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
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtCCCD = new TextBox();
            txtHoVaTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboPhongBan = new ComboBox();
            label10 = new Label();
            cboChucVu = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label8 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label7 = new Label();
            txtMaNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            dataGridView.Size = new Size(1372, 299);
            dataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 386);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1378, 325);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1256, 178);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1256, 116);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1256, 58);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1124, 177);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1124, 115);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1124, 57);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(998, 177);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(998, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(998, 57);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(617, 288);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(346, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(166, 288);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(318, 27);
            txtCCCD.TabIndex = 10;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(616, 52);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(347, 27);
            txtHoVaTen.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(625, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(166, 230);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(318, 27);
            txtSDT.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 230);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 288);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 288);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 62);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 233);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 61);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboPhongBan);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1378, 359);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboPhongBan
            // 
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(617, 169);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(346, 28);
            cboPhongBan.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(521, 172);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 27;
            label10.Text = "Phòng ban";
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(166, 169);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(318, 28);
            cboChucVu.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 172);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 25;
            label9.Text = "Chức vụ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoNu);
            groupBox3.Controls.Add(rdoNam);
            groupBox3.Location = new Point(617, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 48);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(193, 16);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 1;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(72, 16);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(529, 125);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 23;
            label8.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(166, 119);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(318, 27);
            dtpNgaySinh.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 119);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 21;
            label7.Text = "Ngày sinh";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(166, 59);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(318, 27);
            txtMaNV.TabIndex = 6;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 734);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtCCCD;
        private TextBox txtHoVaTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaNV;
        private GroupBox groupBox3;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label8;
        private DateTimePicker dtpNgaySinh;
        private Label label7;
        private Label label10;
        private ComboBox cboChucVu;
        private Label label9;
        private ComboBox cboPhongBan;
    }
}