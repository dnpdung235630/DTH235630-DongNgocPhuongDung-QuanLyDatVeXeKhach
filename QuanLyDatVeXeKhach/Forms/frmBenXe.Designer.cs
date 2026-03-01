namespace QuanLyDatVeXeKhach.Forms
{
    partial class frmBenXe
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
            txtTinhTP = new TextBox();
            txtTenBenXe = new TextBox();
            txtXaPhuong = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSDT = new TextBox();
            label4 = new Label();
            DiaChi = new DataGridViewTextBoxColumn();
            TinhTP = new DataGridViewTextBoxColumn();
            XaPhuong = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            TenBenXe = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1236, 179);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1236, 117);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1236, 59);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1104, 178);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
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
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(166, 179);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(773, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTinhTP
            // 
            txtTinhTP.Location = new Point(592, 121);
            txtTinhTP.Name = "txtTinhTP";
            txtTinhTP.Size = new Size(347, 27);
            txtTinhTP.TabIndex = 10;
            // 
            // txtTenBenXe
            // 
            txtTenBenXe.Location = new Point(166, 51);
            txtTenBenXe.Name = "txtTenBenXe";
            txtTenBenXe.Size = new Size(250, 27);
            txtTenBenXe.TabIndex = 9;
            // 
            // txtXaPhuong
            // 
            txtXaPhuong.Location = new Point(166, 117);
            txtXaPhuong.Name = "txtXaPhuong";
            txtXaPhuong.Size = new Size(250, 27);
            txtXaPhuong.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(23, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1363, 415);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách bến xe";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenBenXe, SDT, XaPhuong, TinhTP, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1357, 389);
            dataGridView.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 182);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 120);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 4;
            label5.Text = "Tỉnh / Thành phố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 120);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Xã / Phường";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bến xe";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label4);
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
            groupBox1.Controls.Add(txtTinhTP);
            groupBox1.Controls.Add(txtTenBenXe);
            groupBox1.Controls.Add(txtXaPhuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1363, 252);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bến xe";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(593, 47);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 54);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 21;
            label4.Text = "Số điện thoại";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TinhTP
            // 
            TinhTP.HeaderText = "Tỉnh / Thành phố";
            TinhTP.MinimumWidth = 6;
            TinhTP.Name = "TinhTP";
            // 
            // XaPhuong
            // 
            XaPhuong.HeaderText = "Xã / Phường";
            XaPhuong.MinimumWidth = 6;
            XaPhuong.Name = "XaPhuong";
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            // 
            // TenBenXe
            // 
            TenBenXe.HeaderText = "Tên bến xe";
            TenBenXe.MinimumWidth = 6;
            TenBenXe.Name = "TenBenXe";
            // 
            // frmBenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 735);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBenXe";
            Text = "frmBenXe";
            Load += frmBenXe_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private TextBox txtTinhTP;
        private TextBox txtTenBenXe;
        private TextBox txtXaPhuong;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSDT;
        private Label label4;
        private DataGridViewTextBoxColumn TenBenXe;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn XaPhuong;
        private DataGridViewTextBoxColumn TinhTP;
        private DataGridViewTextBoxColumn DiaChi;
    }
}