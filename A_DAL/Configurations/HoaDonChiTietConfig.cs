using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    internal class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.IdHoaDon);
            builder.HasKey(x => x.IdDatPhong);

            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonChiTiets).HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(p => p.PhieuDatPhong).WithMany(p => p.HoaDonChiTiets).HasForeignKey(p => p.IdDatPhong);
        }
    }
}