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
    public partial class frmXe : Form
    {
        public frmXe()
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
            txtMaBienSo.Enabled = !giaTri;
            txtMaXe.Enabled = !giaTri;
            numSucChua.Enabled = !giaTri;
            cboLoaiXe.Enabled = !giaTri;
            cboTinhTrang.Enabled = !giaTri;
            txtMoTa.Enabled = !giaTri;
            numGheNgoi.Enabled = !giaTri;
            numGiuongNam.Enabled = !giaTri;
            picHinhAnh.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<Xe> xe = new List<Xe>();
            xe = context.Xe.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = xe;
            txtMaXe.DataBindings.Clear();
            txtMaXe.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);
            txtMaBienSo.DataBindings.Clear();
            txtMaBienSo.DataBindings.Add("Text", bindingSource, "MaBienSo", false, DataSourceUpdateMode.Never);
            cboLoaiXe.DataBindings.Clear();
            cboLoaiXe.DataBindings.Add("SelectedValue", bindingSource, "LoaiXeID", false, DataSourceUpdateMode.Never);
            numSucChua.DataBindings.Clear();
            numSucChua.DataBindings.Add("Value", bindingSource, "SucChua", false, DataSourceUpdateMode.Never);
            numGheNgoi.DataBindings.Clear();
            numGheNgoi.DataBindings.Add("Value", bindingSource, "SoChoNgoi", false, DataSourceUpdateMode.Never);
            numGiuongNam.DataBindings.Clear();
            numGiuongNam.DataBindings.Add("Value", bindingSource, "SoChoNam", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaXe.Clear();
            txtMaBienSo.Clear();
            cboLoaiXe.SelectedIndex = -1;
            numSucChua.Value = 0;
            numGheNgoi.Value = 0;
            numGiuongNam.Value = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thông tin xe " + txtMaXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Xe xe = context.Xe.Find(id);
                if (xe != null)
                {
                    context.Xe.Remove(xe);
                }
                context.SaveChanges();
                frmXe_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text) || string.IsNullOrEmpty(txtMaBienSo.Text) || cboLoaiXe.SelectedIndex == -1 || cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (context.Xe.Any(x => x.MaXe == txtMaXe.Text) && xuLyThem)
            {
                MessageBox.Show("Mã xe đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (context.Xe.Any(x => x.MaBienSo == txtMaBienSo.Text) && xuLyThem)
            {
                MessageBox.Show("Mã biển số đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (context.Xe.Any(x => x.MaXe == txtMaXe.Text && x.ID != id) && !xuLyThem)
            {
                MessageBox.Show("Mã xe đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (context.Xe.Any(x => x.MaBienSo == txtMaBienSo.Text && x.ID != id) && !xuLyThem)
            {
                MessageBox.Show("Mã biển số đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numGheNgoi.Value + numGiuongNam.Value != numSucChua.Value)
            {
                MessageBox.Show("Tổng số ghế ngồi và giường nằm phải bằng sức chứa của xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numGheNgoi.Value < 0 || numGiuongNam.Value < 0 || numSucChua.Value < 0)
            {
                MessageBox.Show("Số ghế ngồi, giường nằm và sức chứa phải là số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else
            {
                if (xuLyThem)
                {
                    Xe xe = new Xe();
                    xe.MaXe = txtMaXe.Text;
                    xe.MaBienSo = txtMaBienSo.Text;
                    xe.LoaiXeID = Convert.ToInt32(cboLoaiXe.SelectedValue);
                    xe.SoChoNgoi = Convert.ToInt32(numSucChua.Value);
                    xe.SoChoNam = Convert.ToInt32(numGiuongNam.Value);
                    xe.SucChua = Convert.ToInt32(numSucChua.Value);
                    xe.TinhTrang = cboTinhTrang.SelectedValue.ToString();
                    xe.MoTa = txtMoTa.Text;
                    xe.HinhAnh = picHinhAnh.Text;
                    context.Xe.Add(xe);
                    context.SaveChanges();
                }
                else
                {
                    Xe xe = context.Xe.Find(id);
                    if (xe != null)
                    {
                        xe.MaXe = txtMaXe.Text;
                        xe.MaBienSo = txtMaBienSo.Text;
                        xe.LoaiXeID = Convert.ToInt32(cboLoaiXe.SelectedValue);
                        xe.SoChoNgoi = Convert.ToInt32(numSucChua.Value);
                        xe.SoChoNam = Convert.ToInt32(numGiuongNam.Value);
                        xe.SucChua = Convert.ToInt32(numSucChua.Value);
                        xe.TinhTrang = cboTinhTrang.SelectedValue.ToString();
                        xe.MoTa = txtMoTa.Text;
                        xe.HinhAnh = picHinhAnh.Text;
                        context.Xe.Update(xe);
                        context.SaveChanges();
                    }
                }
                frmXe_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmXe_Load(sender, e);
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
                                Xe xe = new Xe();
                                xe.MaXe = r["MaXe"].ToString();
                                xe.MaBienSo = r["MaBienSo"].ToString();
                                xe.LoaiXeID = Convert.ToInt32(r["LoaiXeID"].ToString());
                                xe.SoChoNgoi = Convert.ToInt32(r["SoChoNgoi"].ToString());
                                xe.SoChoNam = Convert.ToInt32(r["SoChoNam"].ToString());
                                xe.SucChua = Convert.ToInt32(r["SucChua"].ToString());
                                xe.TinhTrang = r["TinhTrang"].ToString();
                                xe.MoTa = r["MoTa"].ToString();
                                xe.HinhAnh = r["HinhAnh"].ToString();
                                context.Xe.Add(xe);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmXe_Load(sender, e);
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
            saveFileDialog.FileName = "Xe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[10] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("MaXe", typeof(string)),
                        new DataColumn("MaBienSo", typeof(string)),
                        new DataColumn("LoaiXeID", typeof(int)),
                        new DataColumn("SoChoNgoi", typeof(int)),
                        new DataColumn("SoChoNam", typeof(int)),
                        new DataColumn("SucChua", typeof(int)),
                        new DataColumn("TinhTrang", typeof(string)),
                        new DataColumn("MoTa", typeof(string)),
                        new DataColumn("HinhAnh", typeof(string))
                        });
                    var xe = context.Xe.ToList();
                    if (xe != null)
                    {
                        foreach (var p in xe)
                            table.Rows.Add(p.ID, p.MaXe, p.MaBienSo, p.LoaiXeID, p.SoChoNgoi, p.SoChoNam, p.SucChua, p.TinhTrang, p.MoTa,p.HinhAnh);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Xe");
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
