using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class Xe
    {
        public int ID { get; set; }
        public string BienSoXe { get; set; }
        public string HangXe { get; set; }
        public int SoChoNgoi { get; set; }
        public DateTime NamSanXuat { get; set; }
        public double QuangDuongLanBanh { get; set; } // tính theo km 
        public string LoaiXe { get; set; } // Limousine, giường nằm, ghế ngồi, giường phòng, hỗn hợp,...
        public string TinhTrang { get; set; } // Hoạt động, bảo trì, sửa chữa
    }

}
