using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    internal class LoaiXe
    {
        public int ID { get; set; }
        public string TenLoaiXe { get; set; }
        public string? SoDoChoNgoi { get; set; } //hinh anh so do cho ngoi cua xe
        public virtual ObservableCollectionListSource<Xe> Xe { get; } = new();
    }
}
