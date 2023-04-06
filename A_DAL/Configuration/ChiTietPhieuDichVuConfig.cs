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
    public class ChiTietPhieuDichVuConfig : IEntityTypeConfiguration<ChiTietPhieuDichVu>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuDichVu> builder)
        {
            builder.HasOne<DichVu>(x => x.DichVu).WithMany(x => x.ChiTietPhieuDichVus).HasForeignKey(x => x.DichVuID).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne<PhieuDichVu>(x => x.PhieuDichVu).WithMany(x => x.ChiTietPhieuDichVus).HasForeignKey(x => x.PhieuDichVuID).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
