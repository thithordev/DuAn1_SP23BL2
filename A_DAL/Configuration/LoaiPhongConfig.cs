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
    public class LoaiPhongConfig : IEntityTypeConfiguration<LoaiPhong>
    {
        public void Configure(EntityTypeBuilder<LoaiPhong> builder)
        {
<<<<<<< HEAD:A_DAL/Configuration/LoaiPhongConfig.cs

=======
            builder.ToTable("LoaiPhong");
            builder.HasKey(p=> p.Id);
            builder.Property(p => p.Ten).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.SoGiuong).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GiaNgay).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
            builder.Property(p => p.GiaGio).IsRequired().IsUnicode().HasMaxLength(50).IsFixedLength();
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0:A_DAL/Configurations/LoaiPhongConfig.cs
        }
    }
}
