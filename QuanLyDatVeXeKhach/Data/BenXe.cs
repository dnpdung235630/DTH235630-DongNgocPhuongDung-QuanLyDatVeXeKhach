using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class BenXe
    {
        public int ID { get; set; }
        public string TenBenXe { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int ID_DiaDiem { get; set; }
        public int ID_TuyenXe { get; set; }
    }

}
