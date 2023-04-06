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
    public class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasMany<PhieuDatPhong>(x => x.PhieuDatPhongs)
                .WithOne(x => x.HoaDon)
                .HasForeignKey(x => x.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.HoaDons)
                .HasForeignKey(x => x.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<KhachHang>(x => x.KhachHang)
                .WithMany(x => x.HoaDons)
                .HasForeignKey(x => x.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
