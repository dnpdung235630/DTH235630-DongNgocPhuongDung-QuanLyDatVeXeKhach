using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int KhachHangID { get; set; } // ID của khách hàng
        public int NhanVienID { get; set; } // ID của nhân viên hỗ trợ (nếu có)
        public int VeXeID { get; set; } // ID của đặt vé liên quan
        public DateTime NgayLapHoaDon { get; set; }
        public double TongTien { get; set; }
        public int ThanhToanID { get; set; } // ID của phương thức thanh toán
        public int KhuyenMaiID { get; set; } // ID của chương trình khuyến mãi (nếu có)
        public virtual ObservableCollectionListSource<ThanhToan> ThanhToan { get; } = new();
    }

}
