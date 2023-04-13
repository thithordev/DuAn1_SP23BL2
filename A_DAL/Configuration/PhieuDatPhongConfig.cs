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
    public class PhieuDatPhongConfig : IEntityTypeConfiguration<PhieuDatPhong>
    {
        public void Configure(EntityTypeBuilder<PhieuDatPhong> builder)
        {
            builder.HasMany<PhieuDichVu>(x => x.PhieuDichVus)
                .WithOne(x => x.PhieuDatPhong)
                .HasForeignKey(x => x.PhieuDatPhongId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<Phong>(x => x.Phong)
                .WithMany(x => x.PhieuDatPhongs)
                .HasForeignKey(x => x.PhongId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.PhieuDatPhongs)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<KhachHang>(x => x.KhachHang)
                .WithMany(x => x.PhieuDatPhongs)
                .HasForeignKey(x => x.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<HoaDon>(x => x.HoaDon)
                .WithMany(x => x.PhieuDatPhongs)
                .HasForeignKey(x => x.HoaDonId)
                .OnDelete(DeleteBehavior.SetNull);

            //builder.Property(p => p.TrangThai).HasDefaultValue<int>(1);

            //builder.Property(p => p.KieuDat).HasDefaultValue<int>(1);
        }
    }
}
