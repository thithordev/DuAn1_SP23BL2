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
    internal class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            //
            builder.Property(p => p.HoTen).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength(); 
            builder.Property(p => p.CCCD).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.SDT).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GioiTinh).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.DiaChi).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GhiChu).IsRequired().IsUnicode().HasMaxLength(100).IsFixedLength();
        }
    }
}
