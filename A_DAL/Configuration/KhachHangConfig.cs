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
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasMany<PhieuDatPhong>(x => x.PhieuDatPhongs)
                .WithOne(x => x.KhachHang)
                .HasForeignKey(x => x.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany<HoaDon>(x => x.HoaDons)
                .WithOne(x => x.KhachHang)
                .HasForeignKey(x => x.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
