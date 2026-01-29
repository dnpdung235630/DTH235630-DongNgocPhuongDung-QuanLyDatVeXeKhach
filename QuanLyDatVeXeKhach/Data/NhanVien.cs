using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class NhanVien : Nguoi
    {
        //kế thừa lớp người (họ tên, ngày sinh, giới tính, số điện thoại, địa chỉ)
        public int ID { get; set; }
        public string MaNhanVien { get; set; } //bao gồm tài xế
        public int IDChucVu { get; set; }
        public int IDPhongBan { get; set; }
        public int IDTrinhDo { get; set; }
        public int IDPhanQuyen { get; set; }
    }

}
