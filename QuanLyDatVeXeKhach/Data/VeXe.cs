using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class VeXe
    {
        public int ID { get; set; }
        public int ID_ChuyenXe { get; set; }
        public int ID_ViTriGhe { get; set; }
        public int ID_NhanVien { get; set; } // nhân viên phụ trách (đặt trên hệ thống và in vé trực tiếp cho khách tại quầy bán vé)
        public int ID_DiaDiemDi { get; set; }
        public int ID_DiaDiemDen { get; set; }
        public int ID_HoaDon { get; set; } // 1 hóa đơn có thể bao gồm nhiều vé
        public string TenHanhKhach { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayGioDatVe { get; set; }
        public double GiaVe { get; set; }
        public string TrangThai { get; set; } // Đã thanh toán, Chưa thanh toán, Đã hủy
    }

}
