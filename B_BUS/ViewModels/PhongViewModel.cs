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
    public class PhongViewModel : BaseVM
    {
        public Guid? LoaiPhongId { get; set; }
        public string? Ten { get; set; }
        public int? TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }
}
