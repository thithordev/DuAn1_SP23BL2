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
    public class PhieuDichVuConfig : IEntityTypeConfiguration<PhieuDichVu>
    {
        public void Configure(EntityTypeBuilder<PhieuDichVu> builder)
        {
            builder.HasMany<ChiTietPhieuDichVu>(x => x.ChiTietPhieuDichVus)
                .WithOne(x => x.PhieuDichVu)
                .HasForeignKey(x => x.PhieuDichVuID)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<PhieuDatPhong>(x => x.PhieuDatPhong)
                .WithMany(x => x.PhieuDichVus)
                .HasForeignKey(x => x.PhieuDatPhongId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.PhieuDichVus)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.TrangThai).HasDefaultValue<int>(1);
        }
    }
}
