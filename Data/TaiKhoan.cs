using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    internal class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int KhachHangID { get; set; }
        public int NhanVienID { get; set; }
        public int PhanQuyenID { get; set; } // "NhanVien" hoặc "KhachHang"
    }
}
