using ClosedXML.Excel;
using QuanLyDatVeXeKhach.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDatVeXeKhach.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QLDVXKDbContext context = new QLDVXKDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", bindingSource, "CCCD", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            rdoNu.DataBindings.Clear();
            rdoNu.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            rdoNam.DataBindings.Clear();
            rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);
            cboPhongBan.DataBindings.Clear();
            cboPhongBan.DataBindings.Add("Text", bindingSource, "PhongBan", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            cboPhongBan.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtCCCD.Text))
                MessageBox.Show("Vui lòng nhập CCCD nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                MessageBox.Show("Vui lòng nhập email nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboChucVu.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn chức vụ nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboPhongBan.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn phòng ban nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!rdoNam.Checked && !rdoNu.Checked)
                MessageBox.Show("Vui lòng chọn giới tính nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtpNgaySinh.Value > DateTime.Now)
                MessageBox.Show("Ngày sinh không hợp lệ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (context.KhachHang.Any(k => k.CCCD == txtCCCD.Text && k.ID != id))
                MessageBox.Show("CCCD đã tồn tại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (context.KhachHang.Any(k => k.SoDienThoai == txtSDT.Text && k.ID != id))
                MessageBox.Show("Số điện thoại đã tồn tại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (context.KhachHang.Any(k => k.Email == txtEmail.Text && k.ID != id))
                MessageBox.Show("Email đã tồn tại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
                MessageBox.Show("Số điện thoại phải có 10 hoặc 11 chữ số?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!txtSDT.Text.All(char.IsDigit))
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                MessageBox.Show("Email không hợp lệ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtpNgaySinh.Value > DateTime.Now.AddYears(-18))
                MessageBox.Show("Nhân viên phải đủ 18 tuổi?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtpNgaySinh.Value < DateTime.Now.AddYears(-100))
                MessageBox.Show("Ngày sinh không hợp lệ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtHoVaTen.Text.Length > 100)
                MessageBox.Show("Họ và tên không được vượt quá 100 ký tự?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtCCCD.Text.Length != 12)
                MessageBox.Show("CCCD phải có 12 chữ số?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtEmail.Text.Length > 100)
                MessageBox.Show("Email không được vượt quá 100 ký tự?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDiaChi.Text.Length > 200)
                MessageBox.Show("Địa chỉ không được vượt quá 200 ký tự?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.CCCD = txtCCCD.Text;
                    nv.SoDienThoai = txtSDT.Text;
                    nv.GioiTinh = rdoNam.Checked = true ? false : true;
                    nv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                    nv.Email = txtEmail.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.ChucVu = cboChucVu.SelectedValue.ToString();
                    nv.PhongBan = cboPhongBan.SelectedValue.ToString();
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.CCCD = txtCCCD.Text;
                        nv.SoDienThoai = txtSDT.Text;
                        nv.GioiTinh = rdoNam.Checked = true ? false : true;
                        nv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                        nv.Email = txtEmail.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.ChucVu = cboChucVu.SelectedValue.ToString();
                        nv.PhongBan = cboPhongBan.SelectedValue.ToString();
                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoVaTen = r["HoVaTen"].ToString();
                                nv.CCCD = r["CCCD"].ToString(); 
                                nv.SoDienThoai = r["SoDienThoai"].ToString();
                                nv.GioiTinh = r["GioiTinh"].ToString() == "Nam" ? false : true;
                                nv.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString()).ToString("yyyy-MM-dd");
                                nv.Email = r["Email"].ToString();
                                nv.DiaChi = r["DiaChi"].ToString();
                                nv.ChucVu = r["ChucVu"].ToString();
                                nv.PhongBan = r["PhongBan"].ToString();

                                context.NhanVien.Add(nv);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[10] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoVaTen", typeof(string)),
                        new DataColumn("CCCD", typeof(string)),
                        new DataColumn("SoDienThoai", typeof(string)),
                        new DataColumn("GioiTinh", typeof(bool)),
                        new DataColumn("NgaySinh", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("ChucVu", typeof(string)),
                        new DataColumn("PhongBan", typeof(string))
                        });
                    var nhanVien = context.NhanVien.ToList();
                    if (nhanVien != null)
                    {
                        foreach (var p in nhanVien)
                            table.Rows.Add(p.ID, p.HoVaTen, p.CCCD, p.SoDienThoai, p.GioiTinh, p.NgaySinh, p.Email, p.DiaChi, p.ChucVu, p.PhongBan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
