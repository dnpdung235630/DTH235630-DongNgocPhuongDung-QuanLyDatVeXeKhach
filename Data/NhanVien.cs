using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaNhanVien { get; set; } //bao gồm tài xế
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }

}
