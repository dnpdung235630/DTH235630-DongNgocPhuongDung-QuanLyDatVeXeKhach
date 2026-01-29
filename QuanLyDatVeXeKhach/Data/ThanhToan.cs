using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class ThanhToan
    {
        public int ID { get; set; }
        public string HinhThucThanhToan { get; set; } // Ví dụ: Tiền mặt, Thẻ tín dụng, Chuyển khoản
        public string SoTaiKhoan { get; set; } // Áp dụng cho thẻ tín dụng hoặc chuyển khoản
        public string NganHang { get; set; } // Áp dụng cho thẻ tín dụng hoặc chuyển khoản
        public DateTime NgayGioThanhToan { get; set; }
        public double SoTien { get; set; }
    }

}
