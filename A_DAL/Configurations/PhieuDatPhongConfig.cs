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
    internal class PhieuDatPhongConfig : IEntityTypeConfiguration<PhieuDatPhong>
    {
        public void Configure(EntityTypeBuilder<PhieuDatPhong> builder)
        {
            builder.ToTable("PhieuDatPhong");
            builder.HasKey(p => p.Id);
            builder.HasOne(p=>p)
        }
    }
}
