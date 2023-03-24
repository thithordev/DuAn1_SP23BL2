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
<<<<<<< HEAD:A_DAL/Configuration/PhieuDatPhongConfig.cs

=======
            builder.ToTable("PhieuDatPhong");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NgayDat).IsRequired();
            builder.Property(p => p.ThoiGianDat).IsRequired();
            builder.Property(p => p.NgayNhan).IsRequired();
            builder.Property(p => p.NgayTra).IsRequired();
            builder.Property(p => p.GhiChu).IsUnicode().IsFixedLength().HasMaxLength(50);
            builder.HasOne(p => p.KhachHang).WithMany(p => p.PhieuDatPhongs).HasForeignKey(p => p.IdKhachHang);
            builder.HasOne(p => p.NhanVien).WithMany(p => p.PhieuDatPhongs).HasForeignKey(p => p.IdNhanVien);
            builder.HasOne(p => p.Phong).WithMany(p => p.PhieuDatPhongs).HasForeignKey(p => p.IdPhong);
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0:A_DAL/Configurations/PhieuDatPhongConfig.cs
        }
    }
}
