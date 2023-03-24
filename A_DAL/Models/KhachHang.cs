using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
<<<<<<< HEAD
        [Key]
        public Guid IdKhachHang { get; set; }
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? CCCD { get; set; }
        public string? SDT { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
        public virtual List<HoaDon>? HoaDons { get; set; }
        public virtual List<PhieuDichVu>? PhieuDichVus { get; set; }
=======
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public virtual List<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
        public virtual List<PhieuDichVu> PhieuDichVus { get; set; }
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0


    }
}
