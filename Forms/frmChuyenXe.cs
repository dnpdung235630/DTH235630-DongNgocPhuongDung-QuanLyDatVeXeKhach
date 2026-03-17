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
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }
        QLDVXKDbContext context = new QLDVXKDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            btnThoat.Enabled = giaTri;
            txtMaXe.Enabled = giaTri;
            cboTuyenXe.Enabled = giaTri;
            cboTaiXe.Enabled = giaTri;
            cboNhanVienPhuTrach.Enabled = giaTri;
            cboDichVu.Enabled = giaTri;
            txtGioKhoiHanh.Enabled = giaTri;
            dtpNgayKhoiHanh.Enabled = giaTri;
            numGiaVe.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<BenXe> bx = new List<BenXe>();
            bx = context.BenXe.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bx;
            txtMaXe.DataBindings.Clear();
            txtMaXe.DataBindings.Add("Text", bindingSource, "BienSo", false, DataSourceUpdateMode.Never);
            cboTuyenXe.DataBindings.Clear();
            cboTuyenXe.DataBindings.Add("Text", bindingSource, "TenTuyenXe", false, DataSourceUpdateMode.Never);
            cboTaiXe.DataBindings.Clear();
            cboTaiXe.DataBindings.Add("Text", bindingSource, "TenTaiXe", false, DataSourceUpdateMode.Never);
            cboNhanVienPhuTrach.DataBindings.Clear();
            cboNhanVienPhuTrach.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            cboDichVu.DataBindings.Clear();
            cboDichVu.DataBindings.Add("Text", bindingSource, "TenDichVu", false, DataSourceUpdateMode.Never);
            numGiaVe.DataBindings.Clear();
            numGiaVe.DataBindings.Add("Value", bindingSource, "GiaVe", false, DataSourceUpdateMode.Never);
            txtGioKhoiHanh.DataBindings.Clear();
            txtGioKhoiHanh.DataBindings.Add("Text", bindingSource, "GioKhoiHanh", false, DataSourceUpdateMode.Never);
            dtpNgayKhoiHanh.DataBindings.Clear();
            dtpNgayKhoiHanh.DataBindings.Add("Text", bindingSource, "NgayKhoiHanh", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaXe.Clear();
            cboTuyenXe.SelectedIndex = -1;
            cboTaiXe.SelectedIndex = -1;
            cboNhanVienPhuTrach.SelectedIndex = -1;
            cboDichVu.SelectedIndex = -1;
            numGiaVe.Value = 0;
            txtGioKhoiHanh.Clear();
            dtpNgayKhoiHanh.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chuyến xe?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                ChuyenXe cx = context.ChuyenXe.Find(id);
                if (cx != null)
                {
                    context.ChuyenXe.Remove(cx);
                }
                context.SaveChanges();
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaXe.Text) || string.IsNullOrEmpty(txtGioKhoiHanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!DateTime.TryParse(txtGioKhoiHanh.Text, out _))
            {
                MessageBox.Show("Giờ khởi hành không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTuyenXe.SelectedIndex == -1 || cboTaiXe.SelectedIndex == -1 || cboNhanVienPhuTrach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tuyến xe, tài xế và nhân viên phụ trách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpNgayKhoiHanh.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày khởi hành phải là ngày hôm nay hoặc trong tương lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpNgayKhoiHanh.Value.Date == DateTime.Now.Date && DateTime.TryParse(txtGioKhoiHanh.Text, out DateTime gioKhoiHanh) && gioKhoiHanh < DateTime.Now)
            {
                MessageBox.Show("Giờ khởi hành phải là giờ hiện tại hoặc trong tương lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (context.ChuyenXe.Any(cx => cx.XeID.ToString() == txtMaXe.Text && (xuLyThem || cx.ID != id)))
            {
                MessageBox.Show("Mã xe đã tồn tại. Vui lòng chọn mã xe khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!context.TuyenXe.Any(tx => tx.TenTuyenXe == cboTuyenXe.Text))
            {
                MessageBox.Show("Tuyến xe không tồn tại. Vui lòng chọn tuyến xe hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numGiaVe.Value < 0)
            {
                MessageBox.Show("Giá vé không được âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (xuLyThem)
                {
                    ChuyenXe cx = new ChuyenXe();
                    cx.BienSo = txtMaXe.Text;
                    cx.TenTuyenXe = cboTuyenXe.SelectedValue.ToString();
                    cx.TenTaiXe = cboTaiXe.SelectedValue.ToString();
                    cx.TenNhanVien = cboNhanVienPhuTrach.SelectedValue.ToString();
                    cx.TenDichVu = cboDichVu.SelectedValue != null ? cboDichVu.SelectedValue.ToString() : string.Empty;
                    cx.GiaVe = (double)numGiaVe.Value;
                    cx.GioKhoiHanh = txtGioKhoiHanh.Text;
                    cx.NgayKhoiHanh = dtpNgayKhoiHanh.Value.Date.Add(DateTime.Parse(txtGioKhoiHanh.Text).TimeOfDay);
                    context.ChuyenXe.Add(cx);
                    context.SaveChanges();
                }
                else
                {
                    ChuyenXe cx = context.ChuyenXe.Find(id);
                    if (cx != null)
                    {
                        cx.BienSo = txtMaXe.Text;
                        cx.TenTuyenXe = cboTuyenXe.SelectedValue.ToString();
                        cx.TenTaiXe = cboTaiXe.SelectedValue.ToString();
                        cx.TenNhanVien = cboNhanVienPhuTrach.SelectedValue.ToString();
                        cx.TenDichVu = cboDichVu.SelectedValue != null ? cboDichVu.SelectedValue.ToString() : string.Empty;
                        cx.GiaVe = (double)numGiaVe.Value;
                        cx.GioKhoiHanh = txtGioKhoiHanh.Text;
                        cx.NgayKhoiHanh = dtpNgayKhoiHanh.Value.Date.Add(DateTime.Parse(txtGioKhoiHanh.Text).TimeOfDay);
                        context.ChuyenXe.Update(cx);
                        context.SaveChanges();
                    }
                }
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmChuyenXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

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
                                ChuyenXe cx = new ChuyenXe();
                                cx.BienSo = r["BienSo"].ToString();
                                cx.TenTuyenXe = r["TenTuyenXe"].ToString();
                                cx.TenTaiXe = r["TenTaiXe"].ToString();
                                cx.TenNhanVien = r["TenNhanVien"].ToString();
                                cx.TenDichVu = r["DichVu"].ToString();
                                cx.GiaVe = double.TryParse(r["GiaVe"].ToString(), out double giaVe) ? giaVe : 0;
                                cx.GioKhoiHanh = r["GioKhoiHanh"].ToString();
                                cx.NgayKhoiHanh = DateTime.TryParse(r["NgayKhoiHanh"].ToString(), out DateTime ngayKhoiHanh) ? ngayKhoiHanh : DateTime.Now;
                                context.ChuyenXe.Add(cx);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmChuyenXe_Load(sender, e);
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
            saveFileDialog.FileName = "ChuyenXe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[9] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("BienSo", typeof(string)),
                        new DataColumn("TenTuyenXe", typeof(string)),
                        new DataColumn("TenTaiXe", typeof(string)),
                        new DataColumn("TenNhanVien", typeof(string)),
                        new DataColumn("TenDichVu", typeof(string)),
                        new DataColumn("GiaVe", typeof(double)),
                        new DataColumn("GioKhoiHanh", typeof(string)),
                        new DataColumn("NgayKhoiHanh", typeof(DateTime))
                        });
                    var chuyenXe = context.ChuyenXe.ToList();
                    if (chuyenXe != null)
                    {
                        foreach (var p in chuyenXe)
                            table.Rows.Add(p.ID, p.BienSo, p.TenTuyenXe, p.TenTaiXe, p.TenNhanVien, p.TenDichVu, p.GiaVe, p.GioKhoiHanh, p.NgayKhoiHanh);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "ChuyenXe");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
