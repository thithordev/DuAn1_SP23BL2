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
<<<<<<< HEAD
            builder.HasOne(p => p.).WithMany()
=======
>>>>>>> a6eb37f1ce655eaf1df7adfedbda0f49d36e9582
        }
    }
}
