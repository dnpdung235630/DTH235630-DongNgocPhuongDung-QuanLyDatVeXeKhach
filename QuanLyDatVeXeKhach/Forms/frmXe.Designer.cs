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
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenBenXe = new TextBox();
            txtXaPhuong = new TextBox();
            txtMaBX = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1193, 415);
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
            dataGridView.Size = new Size(1187, 389);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenBenXe);
            groupBox1.Controls.Add(txtXaPhuong);
            groupBox1.Controls.Add(txtMaBX);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1193, 252);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1058, 173);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1058, 111);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1058, 53);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(926, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(926, 110);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(926, 52);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(800, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(800, 110);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(800, 52);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenBenXe
            // 
            txtTenBenXe.Location = new Point(592, 59);
            txtTenBenXe.Name = "txtTenBenXe";
            txtTenBenXe.Size = new Size(156, 27);
            txtTenBenXe.TabIndex = 9;
            // 
            // txtXaPhuong
            // 
            txtXaPhuong.Location = new Point(166, 117);
            txtXaPhuong.Name = "txtXaPhuong";
            txtXaPhuong.Size = new Size(250, 27);
            txtXaPhuong.TabIndex = 7;
            // 
            // txtMaBX
            // 
            txtMaBX.Location = new Point(166, 59);
            txtMaBX.Name = "txtMaBX";
            txtMaBX.Size = new Size(250, 27);
            txtMaBX.TabIndex = 6;
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
            label1.Location = new Point(484, 62);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Biển số xe";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 21;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(468, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 119);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số ghế theo loại";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 84);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 1;
            label6.Text = "Giường nằm:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 38);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(124, 80);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // frmXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 726);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmXe";
            Text = "frmXe";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private TextBox txtTenBenXe;
        private TextBox txtXaPhuong;
        private TextBox txtMaBX;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label5;
    }
}