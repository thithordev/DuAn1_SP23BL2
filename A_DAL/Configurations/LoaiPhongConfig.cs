using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    internal class LoaiPhongConfig : IEntityTypeConfiguration<LoaiPhong>
    {
        public void Configure(EntityTypeBuilder<LoaiPhong> builder)
        {
            builder.ToTable("LoaiPhong");
            builder.HasKey(p=> p.Id);
            builder.Property(p => p.Ten).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.SoGiuong).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GiaNgay).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GiaGio).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
        }
    }
}
