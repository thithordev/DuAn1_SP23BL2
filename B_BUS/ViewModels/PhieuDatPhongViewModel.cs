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
    public class PhieuDatPhongViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? HoaDonId { get; set; }
        public Guid? NhanVienId { get; set; }
        public Guid? PhongId { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayDatTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public decimal? PhiCuoc { get; set; }
        public decimal? PhiPhong { get; set; }
        public string? GhiChu { get; set; }
    }
}