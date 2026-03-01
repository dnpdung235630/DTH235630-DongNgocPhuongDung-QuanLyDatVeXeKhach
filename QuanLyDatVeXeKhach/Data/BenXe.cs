using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class BenXe
    {
        public int ID { get; set; }
        public string TenBenXe { get; set; }
        public string XaPhuong { get; set; }
        public string TinhTP { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();

    }

}
