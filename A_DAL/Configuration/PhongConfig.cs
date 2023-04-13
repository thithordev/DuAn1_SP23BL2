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
    public class PhongConfig : IEntityTypeConfiguration<Phong>
    {
        public void Configure(EntityTypeBuilder<Phong> builder)
        {
            builder.HasMany<PhieuDatPhong>(x => x.PhieuDatPhongs)
               .WithOne(x => x.Phong)
               .HasForeignKey(x => x.PhongId)
               .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<LoaiPhong>(x => x.LoaiPhong)
                .WithMany(x => x.Phongs)
                .HasForeignKey(x => x.LoaiPhongId)
                .OnDelete(DeleteBehavior.SetNull);

            //builder.Property(p => p.TrangThai).HasDefaultValue<int>(1);

            //builder.Property(p => p.Tang).HasDefaultValue<int>(1);
        }
    }
}
