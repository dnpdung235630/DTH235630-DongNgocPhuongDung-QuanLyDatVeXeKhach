using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDatVeXeKhach.Data
{
    internal class QLDVXKDbContext : DbContext
    {
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<ChuyenXe> ChuyenXe { get; set; }
        public DbSet<VeXe> VeXe { get; set; }
        public DbSet<BenXe> BenXe { get; set; }
        public DbSet<TuyenXe> TuyenXe { get; set; }
        public DbSet<Xe> Xe { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<LoaiXe> LoaiXe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-F0T7LKA/SQLEXPRESS;Database=QLDVXK;Intergrated Sercurity=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

            }
        }
    }
}
