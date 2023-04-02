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
    public class YeuCauViewModel : BaseVM
    {
        public Guid? NhanVienId { get; set; }
        public string? Noidung { get; set; }
        public decimal? ChiPhi { get; set; }
        public string? GhiChu { get; set; }
        public int? TrangThai { get; set; }
    }
}
