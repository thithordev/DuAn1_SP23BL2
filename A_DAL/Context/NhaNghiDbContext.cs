using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Context
{
    public class NhaNghiDbContext : DbContext
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            //builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            ////builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information); // Hien thi qua nhieu thong  tin nen comment lai
            //builder.AddConsole();
            builder.AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
            .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
            .AddConsole();
        });
        public DbSet<ChiTietPhieuDichVu> chiTietPhieuDichVus { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<DichVu> dichVus { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<LoaiDoanhThu> loaiDoanhThus { get; set; }
        public DbSet<LoaiPhong> loaiPhongs { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<PhieuDatPhong> phieuDatPhongs { get; set; }
        public DbSet<PhieuDichVu> phieuDichVus { get; set; }
        public DbSet<Phong> phongs { get; set; }
        public DbSet<ThongKeDoanhThu> thongKeDoanhThus { get; set; }
        public DbSet<YeuCau> yeuCaus { get; set; }

        private const string connectionString = $"" +
            $"Data Source=TrungSamSet;" +
            $"Initial Catalog=dbQLNhaNghi;" +
            $"Integrated Security=True;" +
            $"TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
