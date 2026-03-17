using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class ChuyenXe
    {
        public int ID { get; set; }
        public int XeID { get; set; }
        public string BienSo { get; set; }
        public int TuyenXeID { get; set; }
        public string TenTuyenXe { get; set; }
        public int TaiXeID { get; set; } // nhân viên lái xe
        public string TenTaiXe { get; set; }
        public int NhanVienID { get; set; } // nhân viên phụ trách
        public string TenNhanVien { get; set; }
        public int DichVuID { get; set; } // loại dịch vụ (ghế thường, ghế VIP, giường nằm)
        public string TenDichVu { get; set; }
        public string GioKhoiHanh { get; set; } // có thể là giờ khởi hành dự kiến hoặc giờ khởi hành thực tế
        public DateTime NgayKhoiHanh { get; set; }
        public double GiaVe { get; set; } // tính chung theo chuyến và phân biệt theo loại ghế 
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }

}
