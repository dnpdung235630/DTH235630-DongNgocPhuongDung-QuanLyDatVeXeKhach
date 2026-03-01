using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class TuyenXe
    {
        public int ID { get; set; }
        public string TenTuyenXe { get; set; } // Ví dụ: Hà Nội - Hải Phòng
        public int BenXeDauID { get; set; }
        public int BenXeCuoiID { get; set; }
        public double QuangDuong { get; set; } // tính theo km
        public string MoTa { get; set; } //
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();s
    }

}
