using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDichVu { get; set; } // Tên dịch vụ (ví dụ: Đồ ăn nhẹ, Nước uống, Wifi, Vận chuyển hành lý)
        public string MoTa { get; set; } // Mô tả chi tiết về dịch vụ
        public double Gia { get; set; } // Giá của dịch vụ
        public int ID_KhuyenMai { get; set; } // ID chương trình khuyến mãi áp dụng cho dịch vụ (nếu có)
    }

}
