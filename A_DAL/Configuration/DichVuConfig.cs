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
    public class DichVuConfig : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.HasMany<ChiTietPhieuDichVu>(x => x.ChiTietPhieuDichVus)
                .WithOne(x => x.DichVu)
                .HasForeignKey(x => x.DichVuID)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Gia).HasDefaultValue<decimal>(0);

            builder.Property(x => x.TrangThai).HasDefaultValue(true);
        }
    }
}
