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
    internal class PhongConfig : IEntityTypeConfiguration<Phong>
    {
        public void Configure(EntityTypeBuilder<Phong> builder)
        {
            builder.ToTable("Phong");
            builder.HasKey(x => x.Id);
            builder.Property(p=>p.Ten).IsRequired().IsUnicode().IsFixedLength().HasMaxLength(50);
            builder.Property(p =>p.TrangThai).IsRequired().IsUnicode().IsFixedLength().HasMaxLength(50);
            builder.Property(p=>p.GhiChu).IsUnicode().IsFixedLength().HasMaxLength(50);
            builder.HasOne(p => p.LoaiPhong);
        }
    }
}
