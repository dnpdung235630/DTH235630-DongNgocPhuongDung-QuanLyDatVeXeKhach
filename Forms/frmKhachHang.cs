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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
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
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;
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
            cboLoaiKH.DataBindings.Clear();
            cboLoaiKH.DataBindings.Add("Text", bindingSource, "LoaiKhachHang", false, DataSourceUpdateMode.Never);
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
            cboLoaiKH.SelectedIndex = -1;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtCCCD.Text))
                MessageBox.Show("Vui lòng nhập CCCD khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                MessageBox.Show("Vui lòng nhập email khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboLoaiKH.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn loại khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!rdoNam.Checked && !rdoNu.Checked)
                MessageBox.Show("Vui lòng chọn giới tính khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Khách hàng phải đủ 18 tuổi?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (cboLoaiKH.SelectedItem.ToString() != "Thường" && cboLoaiKH.SelectedItem.ToString() != "VIP")
                MessageBox.Show("Loại khách hàng phải là 'Thường' hoặc 'VIP'?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.CCCD = txtCCCD.Text;
                    kh.SoDienThoai = txtSDT.Text;
                    kh.GioiTinh = rdoNam.Checked = true ? false : true;
                    kh.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                    kh.Email = txtEmail.Text;
                    kh.LoaiKhachHang = cboLoaiKH.SelectedItem.ToString();
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.CCCD = txtCCCD.Text;
                        kh.SoDienThoai = txtSDT.Text;
                        kh.GioiTinh = rdoNam.Checked = true ? false : true;
                        kh.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                        kh.Email = txtEmail.Text;
                        kh.LoaiKhachHang = cboLoaiKH.SelectedItem.ToString();
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                    }
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            frmKhachHang_Load(sender, e);

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
                                KhachHang kh = new KhachHang();
                                kh.HoVaTen = r["HoVaTen"].ToString();
                                kh.CCCD = r["CCCD"].ToString();
                                kh.SoDienThoai = r["SoDienThoai"].ToString();
                                kh.GioiTinh = r["GioiTinh"].ToString() == "Nam" ? false : true;
                                kh.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString()).ToString("yyyy-MM-dd");
                                kh.Email = r["Email"].ToString();
                                kh.LoaiKhachHang = r["LoaiKhachHang"].ToString();
                                kh.DiaChi = r["DiaChi"].ToString();
                                context.KhachHang.Add(kh);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhachHang_Load(sender, e);
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
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[9] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoVaTen", typeof(string)),
                        new DataColumn("SoDienThoai", typeof(string)),
                        new DataColumn("NgaySinh", typeof(string)),
                        new DataColumn("CCCD", typeof(string)),
                        new DataColumn("GioiTinh", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("LoaiKhachHang", typeof(string))

                        });
                    var khachHang = context.KhachHang.ToList();
                    if (khachHang != null)
                    {
                        foreach (var p in khachHang)
                            table.Rows.Add(p.ID, p.HoVaTen, p.SoDienThoai, p.NgaySinh, p.CCCD, p.GioiTinh, p.Email, p.DiaChi, p.LoaiKhachHang);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
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
