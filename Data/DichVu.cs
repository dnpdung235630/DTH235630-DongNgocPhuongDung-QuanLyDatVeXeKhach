using DocumentFormat.OpenXml.Presentation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDatVeXeKhach.Data
{
    public class DichVu
    {
        public int ID { get; set; }
        public string MaDichVu { get; set; } // Mã dịch vụ (ví dụ: DV001, DV002)
        public string TenDichVu { get; set; } // Tên dịch vụ (ví dụ: Đồ ăn nhẹ, Nước uống, Wifi, Vận chuyển hành lý)
        public string MoTaDichVu { get; set; } // Mô tả chi tiết về dịch vụ
        public double GiaDichVu { get; set; } // Giá của dịch vụ 
        public virtual ObservableCollectionListSource<ChuyenXe> ChuyenXe { get; } = new();
    }

}
