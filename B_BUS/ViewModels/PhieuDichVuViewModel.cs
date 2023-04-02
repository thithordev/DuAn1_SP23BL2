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
    public class PhieuDichVuViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? NhanVienId { get; set; }
        public Guid? HoaDonId { get; set; }
        public Guid? PhieuDatPhongId { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }
}
