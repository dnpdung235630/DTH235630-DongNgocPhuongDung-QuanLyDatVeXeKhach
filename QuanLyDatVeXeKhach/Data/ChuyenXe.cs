using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class ChuyenXe
    {
        public int ID { get; set; }
        public int ID_TuyenXe { get; set; }
        public int ID_Xe { get; set; }
        public int ID_TaiXe { get; set; } // nhân viên lái xe
        public int ID_NhanVien { get; set; } // nhân viên phụ trách (đặt trên hệ thống và in vé trực tiếp cho khách tại quầy bán vé)
        public DateTime NgayGioKhoiHanh { get; set; }
        public DateTime NgayGioDuKienDen { get; set; }
        public double GiaVe { get; set; } // tính chung theo chuyến và phân biệt theo loại ghế 
    }

}
