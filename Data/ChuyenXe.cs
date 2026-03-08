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
        public int TuyenXeID { get; set; }
        
        public int TaiXeID { get; set; } // nhân viên lái xe
        public int NhanVienID { get; set; } // nhân viên phụ trách
        public int DichVuID { get; set; }
        public DateTime NgayGioKhoiHanh { get; set; }
        public DateTime NgayGioDuKienDen { get; set; }
        public double GiaVe { get; set; } // tính chung theo chuyến và phân biệt theo loại ghế 
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }

}
