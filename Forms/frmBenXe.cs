using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyDatVeXeKhach.Data; // <- added this using

using ClosedXML.Excel; // Thêm thư viện ClosedXML để làm việc với Excel
namespace QuanLyDatVeXeKhach.Forms
{
    public partial class frmBenXe : Form
    {
        public frmBenXe()
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
            txtTenBenXe.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtXaPhuong.Enabled = giaTri;
            txtTinhTP.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmBenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<BenXe> bx = new List<BenXe>();
            bx = context.BenXe.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bx;
            txtTenBenXe.DataBindings.Clear();
            txtTenBenXe.DataBindings.Add("Text", bindingSource, "TenBenXe", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT", false, DataSourceUpdateMode.Never);
            txtXaPhuong.DataBindings.Clear();
            txtXaPhuong.DataBindings.Add("Text", bindingSource, "XaPhuong", false, DataSourceUpdateMode.Never);
            txtTinhTP.DataBindings.Clear();
            txtTinhTP.DataBindings.Add("Text", bindingSource, "TinhTP", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenBenXe.Clear();
            txtSDT.Clear();
            txtXaPhuong.Clear();
            txtTinhTP.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenXe.Text))
                MessageBox.Show("Vui lòng nhập tên bến xe?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
                MessageBox.Show("Vui lòng nhập số điện thoại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtXaPhuong.Text))
                MessageBox.Show("Vui lòng nhập xã phường?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTinhTP.Text))
                MessageBox.Show("Vui lòng nhập tỉnh thành phố?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    BenXe bx = new BenXe();
                    bx.TenBenXe = txtTenBenXe.Text;
                    bx.SoDienThoai = txtSDT.Text;
                    bx.XaPhuong = txtXaPhuong.Text;
                    bx.TinhTP = txtTinhTP.Text;
                    bx.DiaChi = txtDiaChi.Text;
                    context.BenXe.Add(bx);
                    context.SaveChanges();
                }
                else
                {
                    BenXe bx = context.BenXe.Find(id);
                    if (bx != null)
                    {
                        bx.TenBenXe = txtTenBenXe.Text;
                        bx.SoDienThoai = txtSDT.Text;
                        bx.XaPhuong = txtXaPhuong.Text;
                        bx.TinhTP = txtTinhTP.Text;
                        bx.DiaChi = txtDiaChi.Text;
                        context.BenXe.Update(bx);
                        context.SaveChanges();
                    }
                }
                frmBenXe_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa bến xe?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                BenXe bx = context.BenXe.Find(id);
                if (bx != null)
                {
                    context.BenXe.Remove(bx);
                }
                context.SaveChanges();
                frmBenXe_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmBenXe_Load(sender, e);
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
                                BenXe bx = new BenXe();
                                bx.TenBenXe = r["TenBenXe"].ToString();
                                bx.SoDienThoai = r["SDT"].ToString();
                                bx.XaPhuong = r["XaPhuong"].ToString();
                                bx.TinhTP = r["TinhTP"].ToString();
                                bx.DiaChi = r["DiaChi"].ToString();
                                context.BenXe.Add(bx);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmBenXe_Load(sender, e);
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
            saveFileDialog.FileName = "BenXe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[6] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenBenXe", typeof(string)),
                        new DataColumn("SDT", typeof(string)),
                        new DataColumn("XaPhuong", typeof(string)),
                        new DataColumn("TinhTP", typeof(string)),
                        new DataColumn("DiaChi", typeof(string))
                        });
                    var benXe = context.BenXe.ToList();
                    if (benXe != null)
                    {
                        foreach (var p in benXe)
                            table.Rows.Add(p.ID, p.TenBenXe, p.SoDienThoai, p.XaPhuong, p.TinhTP, p.DiaChi);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "BenXe");
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
