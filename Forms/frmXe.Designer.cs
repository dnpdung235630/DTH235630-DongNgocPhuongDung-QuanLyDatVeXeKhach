namespace QuanLyDatVeXeKhach.Forms
{
    partial class frmXe
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
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            cboTinhTrang = new ComboBox();
            groupBox4 = new GroupBox();
            btnDoiAnh = new Button();
            label8 = new Label();
            label7 = new Label();
            numSucChua = new NumericUpDown();
            groupBox3 = new GroupBox();
            numGiuongNam = new NumericUpDown();
            numGheNgoi = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cboLoaiXe = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMaBienSo = new TextBox();
            txtMaXe = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            picHinhAnh = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSucChua).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiuongNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGheNgoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 497);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1193, 277);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách xe";
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
            dataGridView.Size = new Size(1187, 251);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(cboTinhTrang);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numSucChua);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cboLoaiXe);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaBienSo);
            groupBox1.Controls.Add(txtMaXe);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1193, 479);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(166, 302);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(250, 140);
            txtMoTa.TabIndex = 28;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(166, 244);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(250, 28);
            cboTinhTrang.TabIndex = 27;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(picHinhAnh);
            groupBox4.Controls.Add(btnDoiAnh);
            groupBox4.Location = new Point(476, 244);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(315, 213);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hình ảnh";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(207, 105);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 305);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 25;
            label8.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 244);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 24;
            label7.Text = "Tình trạng";
            // 
            // numSucChua
            // 
            numSucChua.Location = new Point(166, 118);
            numSucChua.Name = "numSucChua";
            numSucChua.Size = new Size(250, 27);
            numSucChua.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numGiuongNam);
            groupBox3.Controls.Add(numGheNgoi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(476, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 128);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số ghế theo loại";
            // 
            // numGiuongNam
            // 
            numGiuongNam.Location = new Point(139, 73);
            numGiuongNam.Name = "numGiuongNam";
            numGiuongNam.Size = new Size(150, 27);
            numGiuongNam.TabIndex = 3;
            // 
            // numGheNgoi
            // 
            numGheNgoi.Location = new Point(139, 31);
            numGheNgoi.Name = "numGheNgoi";
            numGheNgoi.Size = new Size(150, 27);
            numGheNgoi.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 84);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 1;
            label6.Text = "Giường nằm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 45);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 0;
            label5.Text = "Ghế ngồi:";
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Location = new Point(166, 180);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(250, 28);
            cboLoaiXe.TabIndex = 21;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1075, 283);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1075, 221);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1075, 163);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(943, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(943, 220);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(943, 162);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(817, 282);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(817, 220);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(817, 162);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaBienSo
            // 
            txtMaBienSo.Location = new Point(615, 56);
            txtMaBienSo.Name = "txtMaBienSo";
            txtMaBienSo.Size = new Size(150, 27);
            txtMaBienSo.TabIndex = 9;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(166, 59);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(250, 27);
            txtMaXe.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 183);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Loại xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 63);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã số xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 120);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Sức chứa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 62);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Biển số xe";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(23, 39);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(163, 155);
            picHinhAnh.TabIndex = 1;
            picHinhAnh.TabStop = false;
            // 
            // frmXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 786);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmXe";
            Text = "frmXe";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSucChua).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiuongNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGheNgoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtMaBienSo;
        private TextBox txtMaXe;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cboLoaiXe;
        private GroupBox groupBox3;
        private NumericUpDown numGiuongNam;
        private NumericUpDown numGheNgoi;
        private Label label6;
        private Label label5;
        private NumericUpDown numSucChua;
        private TextBox txtMoTa;
        private ComboBox cboTinhTrang;
        private GroupBox groupBox4;
        private Label label8;
        private Label label7;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
    }
}