using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class DiemDung
    {
        public int ID { get; set; }
        public string ChuoiDiemDung { get; set; } // Chuỗi các điểm dừng, phân tách bằng dấu '-' (kể cả điểm đầu và điểm cuối)
        public string ChuoiKhoangCach { get; set; } // Chuỗi các khoảng cách tương ứng giữa các điểm dừng, phân tách bằng dấu '-'
    }

}
