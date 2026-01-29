using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class KhachHang : Nguoi
    {
        //kế thừa lớp người (họ tên, ngày sinh, giới tính, số điện thoại, địa chỉ)
        public int ID { get; set; }
        public bool LoaiKhachHang { get; set; } // 0: khách lẻ, 1: khách doanh nghiệp
        public string MaKhachHang { get; set; }
        public int ID_TaiKhoan { get; set; }
    }

}
