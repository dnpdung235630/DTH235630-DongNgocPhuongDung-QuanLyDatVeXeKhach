using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class Ghe
    {
        public int ID { get; set; }
        public string TenGhe { get; set; } // Ví dụ: A1, A2, B1, B2
        public string LoaiGhe { get; set; } // Ví dụ: Ghế ngồi, giường nằm
        public bool TrangThai { get; set; } // true: đã đặt, false: còn trống
        public int XeID { get; set; }
        public virtual ObservableCollectionListSource<Xe> Xe { get; } = new();
    }

}
