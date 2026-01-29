using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class KhuyenMai
    {
        public int ID { get; set; }
        public string TenChuongTrinh { get; set; } // Tên chương trình khuyến mãi
        public string MoTa { get; set; } // Mô tả chi tiết về chương trình khuyến mãi
        public DateTime NgayBatDau { get; set; } // Ngày bắt đầu áp dụng khuyến mãi
        public DateTime NgayKetThuc { get; set; } // Ngày kết thúc khuyến mãi
        public double PhanTramGiamGia { get; set; } // Phần trăm giảm giá áp dụng
    }

}
