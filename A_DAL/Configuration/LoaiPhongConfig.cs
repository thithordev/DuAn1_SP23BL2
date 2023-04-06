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
            builder.HasMany<Phong>(x => x.Phongs)
                .WithOne(x => x.LoaiPhong)
                .HasForeignKey(x => x.LoaiPhongId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
