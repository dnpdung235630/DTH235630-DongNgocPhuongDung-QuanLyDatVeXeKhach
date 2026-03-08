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
        public string LoaiTuyenXe { get; set; }
        public int BenXeDauID { get; set; }
        public int BenXeTrungGian1_ID { get; set; }
        public int BenXeTrungGian2_ID { get; set; }
        public int BenXeCuoiID { get; set; }
        public float QuangDuong1 { get; set; } // điểm đầu đến điểm trung gian 1, tính theo km
        public float QuangDuong2 { get; set; } // điểm trung gian 1 đến điểm trung gian 2, tính theo km
        public float QuangDuong3 { get; set; } // điểm trung gian 2 đến điểm cuối, tính theo km
        public string MoTa { get; set; } //
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }

}
