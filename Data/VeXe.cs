using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class VeXe
    {
        public int ID { get; set; }
        public int ChuyenXeID { get; set; }
        public string TenTuyenXe { get; set; } // Liên kết thông qua tên chuyến xe được định nghĩa theo tuyến xe
        public int GheID { get; set; }
        public string MaGhe { get; set; } // Liên kết thông qua tên ghế được định nghĩa theo xe
        public int NhanVienID { get; set; } // nhân viên phụ trách (đặt trên hệ thống và in vé trực tiếp cho khách tại quầy bán vé)
        public string TenNhanVien { get; set; } // Liên kết thông qua tên nhân viên được định nghĩa theo nhân viên
        public int KhachHangID { get; set; } // khách hàng mua vé (nếu có)
        public string TenKhachHang { get; set; } // Liên kết thông qua tên khách hàng được định nghĩa theo khách hàng
        public string SoDienThoaiKhachHang { get; set; } // Số điện thoại của khách hàng, có thể dùng để liên hệ hoặc xác nhận thông tin đặt vé
        public string GioDatVe { get; set; }
        public DateTime NgayDatVe { get; set; }
        public string TrangThai { get; set; } // Đã thanh toán, Chưa thanh toán, Đã hủy
    }

}
