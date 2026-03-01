using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyDatVeXeKhach.Data; // <- added this using

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
            //txtTenLoai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmBenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<BenXe> lsp = new List<BenXe>();
            lsp = context.BenXe.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;
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
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    BenXe lsp = new BenXe();
                    lsp.TenBenXe = txtTenBenXe.Text;
                    lsp.SoDienThoai = txtSDT.Text;
                    lsp.XaPhuong = txtXaPhuong.Text;
                    lsp.TinhTP = txtTinhTP.Text;
                    lsp.DiaChi = txtDiaChi.Text;
                    context.BenXe.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    BenXe lsp = context.BenXe.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenBenXe = txtTenBenXe.Text;
                        lsp.SoDienThoai = txtSDT.Text;
                        lsp.XaPhuong = txtXaPhuong.Text;
                        lsp.TinhTP = txtTinhTP.Text;
                        lsp.DiaChi = txtDiaChi.Text;
                        context.BenXe.Update(lsp);
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
                BenXe lsp = context.BenXe.Find(id);
                if (lsp != null)
                {
                    context.BenXe.Remove(lsp);
                }
                context.SaveChanges();
                frmBenXe_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmBenXe_Load(sender, e);
        }
    }
}
