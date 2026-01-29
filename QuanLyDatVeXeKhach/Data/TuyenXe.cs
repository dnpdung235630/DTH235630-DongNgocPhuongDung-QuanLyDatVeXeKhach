using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class TuyenXe
    {
        public int ID { get; set; }
        public string TenTuyenXe { get; set; } // Ví dụ: Hà Nội - Hải Phòng
        public int ID_BenXeDau { get; set; }
        public int ID_BenXeCuoi { get; set; }
        public int ID_DiemDung { get; set; } // điểm dừng trung gian, có thể là nhiều điểm dừng, lưu dưới dạng chuỗi phân tách bằng dấu -
        public double QuangDuong { get; set; } // tính theo km
        public string MoTa { get; set; } //
    }

}
