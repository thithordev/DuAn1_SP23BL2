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
    public class LoaiDoanhThuConfig : IEntityTypeConfiguration<LoaiDoanhThu>
    {
        public void Configure(EntityTypeBuilder<LoaiDoanhThu> builder)
        {

        }
    }
}
