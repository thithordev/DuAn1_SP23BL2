using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class ChiTietPhieuDichVuViewModel : BaseVM
    {
        public Guid? PhieuDichVuID { get; set; }
        public Guid? DichVuID { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
    }
}
