using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class Xe
    {
        public int ID { get; set; }
        public string MaBienSo { get; set; }
        public string MaXe { get; set; }
        public int SucChua { get; set; }
        public int SoChoNgoi { get; set; }
        public int SoChoNam { get; set; }
        public string TinhTrang { get; set; } // Hoạt động, bảo trì, sửa chữa
        public string? HinhAnh { get; set; }
        public string MoTa { get; set; } // Mô tả chi tiết về xe, có thể bao gồm thông tin về tiện nghi, dịch vụ trên xe, v.v.

        public int LoaiXeID { get; set; } // Limousine, giường nằm, ghế ngồi, giường phòng, hỗn hợp,...
        public string TenLoaiXe { get; set; } // Tên loại xe, ví dụ: Limousine, giường nằm, ghế ngồi, giường phòng, hỗn hợp,...
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();

    }
}
