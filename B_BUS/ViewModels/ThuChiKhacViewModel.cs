using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class ThuChiKhacViewModel : BaseVM
    {
        public DateTime? NgayTao { get; set; }
        public bool isThu { get; set; }
        public string? NoiDung { get; set; }
        public decimal? SoTien { get; set; }
    }
}
