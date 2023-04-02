using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class NhanVienViewModel : BaseVM
    {
        public Guid? ChucVuId { get; set; }
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? CCCD { get; set; }
        public string? SDT { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public decimal? Luong { get; set; }
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public string? GhiChu { get; set; }

        public virtual ChucVuViewModel? ChucVuViewModel { get; set; }
        public string? TenChucVu { get => ChucVuViewModel?.Ten;}
        public string? QuyenTruyCap { get => ChucVuViewModel?.QuyenTruyCap;}
    }
}
