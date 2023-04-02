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
    public class HoaDonViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? NhanVienId { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        public string? GhiChu { get; set; }
    }
}
