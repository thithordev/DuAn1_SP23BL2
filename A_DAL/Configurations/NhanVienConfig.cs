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
    internal class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            //prop
            builder.Property(p => p.Ten).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.SDT).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.DiaChi).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GioiTinh).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.NgSinh).IsRequired();
            builder.Property(p => p.TrangThai).IsRequired().HasMaxLength(50).IsFixedLength(); 
            builder.Property(p => p.MatKhau).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.Luong).IsRequired().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GhiChu).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            //FK
            builder.HasOne(p => p.ChucVu).WithMany(p => p.NhanViens).HasForeignKey(p => p.IDChucVu);
            builder.HasOne(p => p.CapTren).WithMany(p => p.NhanViens).HasForeignKey(p => p.IDCapTren);
        }
    }
}
