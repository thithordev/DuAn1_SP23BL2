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
    public class ChucVuConfig : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasMany<NhanVien>(x => x.NhanViens)
                .WithOne(x => x.ChucVu)
                .HasForeignKey(x => x.ChucVuId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
