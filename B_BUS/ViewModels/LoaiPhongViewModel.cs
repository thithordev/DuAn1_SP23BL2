using A_DAL.Models;
using B_BUS.DataProviders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class LoaiPhongViewModel
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string? Ten { get; set; }
        public string? Mota { get; set; }
        public int? SoGiuong { get; set; }
        public decimal? GiaNgay { get; set; }
        public decimal? GiaGio { get; set; }
    }
}
