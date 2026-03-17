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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
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
            txtMaDichVu.Enabled = giaTri;
            cboTenDichVu.Enabled = giaTri;
            txtMoTaDichVu.Enabled = giaTri;
            numGiaDichVu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<DichVu> dv = new List<DichVu>();
            dv = context.DichVu.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dv;
            txtMaDichVu.DataBindings.Clear();
            txtMaDichVu.DataBindings.Add("Text", bindingSource, "MaDichVu", false, DataSourceUpdateMode.Never);
            cboTenDichVu.DataBindings.Clear();
            cboTenDichVu.DataBindings.Add("Text", bindingSource, "TenDichVu", false, DataSourceUpdateMode.Never);
            txtMoTaDichVu.DataBindings.Clear();
            txtMoTaDichVu.DataBindings.Add("Text", bindingSource, "MoTaDichVu", false, DataSourceUpdateMode.Never);
            numGiaDichVu.DataBindings.Clear();
            numGiaDichVu.DataBindings.Add("Value", bindingSource, "GiaDichVu", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMaDichVu.Clear();
            cboTenDichVu.SelectedIndex = -1;
            txtMoTaDichVu.Clear();
            numGiaDichVu.Value = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDichVu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTenDichVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(numGiaDichVu.Value <= 0)
            {
                MessageBox.Show("Giá dịch vụ phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (xuLyThem)
                {
                    DichVu dv = new DichVu();
                    dv.MaDichVu = txtMaDichVu.Text;
                    dv.TenDichVu = cboTenDichVu.SelectedItem.ToString();
                    dv.MoTaDichVu = txtMoTaDichVu.Text;
                    dv.GiaDichVu = (float)numGiaDichVu.Value;
                    context.DichVu.Add(dv);
                    context.SaveChanges();
                }
                else
                {
                    DichVu dv = context.DichVu.Find(id);
                    if (dv != null)
                    {
                        dv.MaDichVu = txtMaDichVu.Text;
                        dv.TenDichVu = cboTenDichVu.SelectedItem.ToString();
                        dv.MoTaDichVu = txtMoTaDichVu.Text;
                        dv.GiaDichVu = (float)numGiaDichVu.Value;
                        context.DichVu.Update(dv);
                        context.SaveChanges();
                    }
                }
                frmDichVu_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa dịch vụ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                DichVu dv = context.DichVu.Find(id);
                if (dv != null)
                {
                    context.DichVu.Remove(dv);
                }
                context.SaveChanges();
                frmDichVu_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDichVu_Load(sender, e);
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
                                DichVu dv = new DichVu();
                                dv.MaDichVu = r["MaDichVu"].ToString();
                                dv.TenDichVu = r["TenDichVu"].ToString();
                                dv.MoTaDichVu = r["MoTaDichVu"].ToString();
                                dv.GiaDichVu = float.Parse(r["GiaDichVu"].ToString());
                                context.DichVu.Add(dv);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDichVu_Load(sender, e);
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
            saveFileDialog.FileName = "DichVu_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("MaDichVu", typeof(string)),
                        new DataColumn("TenDichVu", typeof(string)),
                        new DataColumn("MoTaDichVu", typeof(string)),
                        new DataColumn("GiaDichVu", typeof(float))
                        });
                    var dichVu = context.DichVu.ToList();
                    if (dichVu != null)
                    {
                        foreach (var p in dichVu)
                            table.Rows.Add(p.ID, p.MaDichVu, p.TenDichVu, p.MoTaDichVu, p.GiaDichVu);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "DichVu");
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
