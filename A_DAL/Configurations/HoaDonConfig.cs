using A_DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    internal class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.GhiChu).IsUnicode().HasMaxLength(50).IsFixedLength();

            builder.HasOne(p => p.KhachHang).WithMany(p => p.HoaDons).HasForeignKey(p => p.IdKhachHang);
            builder.HasOne(p => p.NhanVien).WithMany(p => p.HoaDons).HasForeignKey(p => p.IdNhanVien);
        }
    }
}
