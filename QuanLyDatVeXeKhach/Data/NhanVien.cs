using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
        public string TrinhDo { get; set; }
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }

}
