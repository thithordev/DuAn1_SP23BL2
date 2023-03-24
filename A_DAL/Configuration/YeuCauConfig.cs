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
    public class YeuCauConfig : IEntityTypeConfiguration<YeuCau>
    {
        public void Configure(EntityTypeBuilder<YeuCau> builder)
        {

        }
    }
}
