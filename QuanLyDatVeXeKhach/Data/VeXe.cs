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
        public int ViTriGheID { get; set; }
        public int NhanVienID { get; set; } // nhân viên phụ trách (đặt trên hệ thống và in vé trực tiếp cho khách tại quầy bán vé)
        public int TuyenXeID { get; set; }
        public int HoaDonID { get; set; } // 1 hóa đơn có thể bao gồm nhiều vé
        public int KhachHangID { get; set; } // khách hàng mua vé (nếu có)
        public DateTime NgayGioDatVe { get; set; }
        public string TrangThai { get; set; } // Đã thanh toán, Chưa thanh toán, Đã hủy
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }

}
