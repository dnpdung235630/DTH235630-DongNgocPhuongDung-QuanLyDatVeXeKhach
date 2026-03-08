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
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
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
        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<TuyenXe> tx = new List<TuyenXe>();
            tx = context.TuyenXe.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tx;
            txtTenTuyenXe.DataBindings.Clear();
            txtTenTuyenXe.DataBindings.Add("Text", bindingSource, "TenTuyenXe");
            cboLoaiTuyen.DataBindings.Clear();
            cboLoaiTuyen.DataBindings.Add("SelectedValue", bindingSource, "LoaiTuyen");
            cboBenDau.DataBindings.Clear();
            cboBenDau.DataBindings.Add("SelectedValue", bindingSource, "BenXeDauID");
            cboTrungGian1.DataBindings.Clear();
            cboTrungGian1.DataBindings.Add("SelectedValue", bindingSource, "BenXeTrungGian1_ID");
            cboTrungGian2.DataBindings.Clear();
            cboTrungGian2.DataBindings.Add("SelectedValue", bindingSource, "BenXeTrungGian2_ID");
            cboBenCuoi.DataBindings.Clear();
            cboBenCuoi.DataBindings.Add("SelectedValue", bindingSource, "BenXeCuoiID");
            numQuangDuong1.DataBindings.Clear();
            numQuangDuong1.DataBindings.Add("Value", bindingSource, "QuangDuong1");
            numQuangDuong2.DataBindings.Clear();
            numQuangDuong2.DataBindings.Add("Value", bindingSource, "QuangDuong2");
            numQuangDuong3.DataBindings.Clear();
            numQuangDuong3.DataBindings.Add("Value", bindingSource, "QuangDuong3");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa");
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenTuyenXe.Clear();
            cboLoaiTuyen.SelectedIndex = -1;
            cboBenDau.SelectedIndex = -1;
            cboTrungGian1.SelectedIndex = -1;
            cboTrungGian2.SelectedIndex = -1;
            cboBenCuoi.SelectedIndex = -1;
            numQuangDuong1.Value = 0;
            numQuangDuong2.Value = 0;
            numQuangDuong3.Value = 0;
            txtMoTa.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tuyến xe " + txtTenTuyenXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                TuyenXe tx = context.TuyenXe.Find(id);
                if (tx != null)
                {
                    context.TuyenXe.Remove(tx);
                }
                context.SaveChanges();
                frmTuyenXe_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTuyenXe.Text))
            {
                MessageBox.Show("Tên tuyến xe không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboLoaiTuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại tuyến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboBenDau.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bến xe đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboBenCuoi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bến xe cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTrungGian1.SelectedIndex != -1 || cboTrungGian1.SelectedValue.ToString() == cboBenDau.SelectedValue.ToString())
            {
                MessageBox.Show("Bến xe trung gian 1 không được trùng với bến xe đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTrungGian1.SelectedIndex != -1 || cboTrungGian1.SelectedValue.ToString() == cboBenCuoi.SelectedValue.ToString())
            {
                MessageBox.Show("Bến xe trung gian 1 không được trùng với bến xe cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTrungGian2.SelectedIndex != -1 || cboTrungGian2.SelectedValue.ToString() == cboBenDau.SelectedValue.ToString())
            {
                MessageBox.Show("Bến xe trung gian 2 không được trùng với bến xe đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTrungGian2.SelectedIndex != -1 || cboTrungGian2.SelectedValue.ToString() == cboBenCuoi.SelectedValue.ToString())
            {
                MessageBox.Show("Bến xe trung gian 2 không được trùng với bến xe cuối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboTrungGian1.SelectedIndex != -1 || cboTrungGian2.SelectedIndex != -1 && cboTrungGian1.SelectedValue.ToString() == cboTrungGian2.SelectedValue.ToString())
            {
                MessageBox.Show("Bến xe trung gian 1 không được trùng với bến xe trung gian 2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong1.Value < 0 || numQuangDuong2.Value < 0 || numQuangDuong3.Value < 0)
            {
                MessageBox.Show("Quãng đường không được nhỏ hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong1.Value == 0 && numQuangDuong2.Value == 0 && numQuangDuong3.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập quãng đường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong2.Value > 0 && numQuangDuong1.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập quãng đường từ bến đầu đến bến xe trung gian 1.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong3.Value > 0 && (numQuangDuong1.Value == 0 || numQuangDuong2.Value == 0))
            {
                MessageBox.Show("Vui lòng nhập quãng đường từ bến đầu đến bến xe trung gian 1 và từ bến xe trung gian 1 đến bến xe trung gian 2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong2.Value > 0 && numQuangDuong3.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập quãng đường từ bến xe trung gian 1 đến bến xe trung gian 2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (numQuangDuong1.Value > 0 && numQuangDuong3.Value > 0 && numQuangDuong2.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập quãng đường từ bến xe trung gian 1 đến bến xe trung gian 2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (xuLyThem)
                {
                    TuyenXe tx = new TuyenXe();
                    tx.TenTuyenXe = txtTenTuyenXe.Text;
                    tx.LoaiTuyenXe = cboLoaiTuyen.SelectedValue.ToString();
                    tx.BenXeDauID = Convert.ToInt32(cboBenDau.SelectedValue.ToString());
                    tx.BenXeTrungGian1_ID = cboTrungGian1.SelectedIndex != -1 ? Convert.ToInt32(cboTrungGian1.SelectedValue.ToString()) : 0;
                    tx.BenXeTrungGian2_ID = cboTrungGian2.SelectedIndex != -1 ? Convert.ToInt32(cboTrungGian2.SelectedValue.ToString()) : 0;
                    tx.BenXeCuoiID = Convert.ToInt32(cboBenCuoi.SelectedValue.ToString());
                    tx.QuangDuong1 = (float)numQuangDuong1.Value;
                    tx.QuangDuong2 = (float)numQuangDuong2.Value;
                    tx.QuangDuong3 = (float)numQuangDuong3.Value;
                    tx.MoTa = txtMoTa.Text;

                    context.TuyenXe.Add(tx);
                    context.SaveChanges();
                }
                else
                {
                    TuyenXe tx = context.TuyenXe.Find(id);
                    if (tx != null)
                    {
                        tx.TenTuyenXe = txtTenTuyenXe.Text;
                        tx.LoaiTuyenXe = cboLoaiTuyen.SelectedValue.ToString();
                        tx.BenXeDauID = Convert.ToInt32(cboBenDau.SelectedValue.ToString());
                        tx.BenXeTrungGian1_ID = cboTrungGian1.SelectedIndex != -1 ? Convert.ToInt32(cboTrungGian1.SelectedValue.ToString()) : 0;
                        tx.BenXeTrungGian2_ID = cboTrungGian2.SelectedIndex != -1 ? Convert.ToInt32(cboTrungGian2.SelectedValue.ToString()) : 0;
                        tx.BenXeCuoiID = Convert.ToInt32(cboBenCuoi.SelectedValue.ToString());
                        tx.QuangDuong1 = (float)numQuangDuong1.Value;
                        tx.QuangDuong2 = (float)numQuangDuong2.Value;
                        tx.QuangDuong3 = (float)numQuangDuong3.Value;
                        tx.MoTa = txtMoTa.Text;

                        context.TuyenXe.Update(tx);
                        context.SaveChanges();
                    }
                }
                frmTuyenXe_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTuyenXe_Load(sender, e);
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
                                TuyenXe tx = new TuyenXe();
                                tx.TenTuyenXe = r["TenTuyenXe"].ToString();
                                tx.LoaiTuyenXe = r["LoaiTuyen"].ToString();
                                tx.BenXeDauID = Convert.ToInt32(r["BenXeDauID"].ToString());
                                tx.BenXeTrungGian1_ID = Convert.ToInt32(r["BenXeTrungGian1_ID"].ToString());
                                tx.BenXeTrungGian2_ID = Convert.ToInt32(r["BenXeTrungGian2_ID"].ToString());
                                tx.BenXeCuoiID = Convert.ToInt32(r["BenXeCuoiID"].ToString());
                                tx.QuangDuong1 = (float)Convert.ToDecimal(r["QuangDuong1"].ToString());
                                tx.QuangDuong2 = (float)Convert.ToDecimal(r["QuangDuong2"].ToString());
                                tx.QuangDuong3 = (float)Convert.ToDecimal(r["QuangDuong3"].ToString());
                                tx.MoTa = r["MoTa"].ToString();
                                context.TuyenXe.Add(tx);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTuyenXe_Load(sender, e);
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
            saveFileDialog.FileName = "TuyenXe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[11] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenTuyenXe",typeof(string)),
                        new DataColumn("LoaiTuyenXe",typeof(string)),
                        new DataColumn("BenXeDauID",typeof(int)),
                        new DataColumn("BenXeTrungGian1_ID",typeof(int)),
                        new DataColumn("BenXeTrungGian2_ID",typeof(int)),
                        new DataColumn("BenXeCuoiID",typeof(int)),
                        new DataColumn("QuangDuong1",typeof(float)),
                        new DataColumn("QuangDuong2",typeof(float)),
                        new DataColumn("QuangDuong3",typeof(float)),
                        new DataColumn("MoTa",typeof(string))
                        });
                    var tuyenXe = context.TuyenXe.ToList();
                    if (tuyenXe != null)
                    {
                        foreach (var p in tuyenXe)
                            table.Rows.Add(p.ID, p.TenTuyenXe,p.LoaiTuyenXe,p.BenXeDauID,p.BenXeTrungGian1_ID, p.BenXeTrungGian2_ID, p.BenXeCuoiID, p.QuangDuong1,p.QuangDuong2, p.QuangDuong3, p.MoTa);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "TuyenXe");
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
