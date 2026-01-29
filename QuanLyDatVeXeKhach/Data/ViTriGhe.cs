using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class ViTriGhe
    {
        public int ID { get; set; }
        public int ID_Xe { get; set; } // Khóa ngoại liên kết đến Xe
        public string TenViTriGhe { get; set; } // Ví dụ: A1, A2, B1, B2
        public string LoaiGhe { get; set; } // Ví dụ: Ghế ngồi, giường nằm

    }

}
