using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A_DAL.Configuration
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasMany<PhieuDatPhong>(x => x.PhieuDatPhongs)
                .WithOne(x => x.NhanVien)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany<PhieuDichVu>(x => x.PhieuDichVus)
                .WithOne(x => x.NhanVien)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany<HoaDon>(x => x.HoaDons)
                .WithOne(x => x.NhanVien)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<ChucVu>(x => x.ChucVu)
                .WithMany(x => x.NhanViens)
                .HasForeignKey(x => x.ChucVuId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(p => p.TenTaiKhoan).IsUnique(true);
        }
    }
}
