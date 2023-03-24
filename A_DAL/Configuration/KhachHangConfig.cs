using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:A_DAL/Configuration/KhachHangConfig.cs
namespace A_DAL.Configuration
{
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {

=======
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
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0:A_DAL/Configurations/KhachHangConfig.cs
        }
    }
}
