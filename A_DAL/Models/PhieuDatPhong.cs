using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("PhieuDatPhong")]
    public class PhieuDatPhong
    {
        [Key]
        public Guid IdPhieuDatPhong { get; set; }
        [ForeignKey("KhachHangId")]
        public Guid? KhachHangId { get; set; }
        [ForeignKey("HoaDonId")]
        public Guid? HoaDonId { get; set; }
        [ForeignKey("NhanVienId")]
        public Guid? NhanVienId { get; set; }
        [ForeignKey("PhongId")]
        public Guid? PhongId { get; set; }
        public DateTime? NgayGioTaoPhieu { get; set; }
        public DateTime? NgayDat { get; set; }
        //public DateOnly NgayNhan { get; set; }
        public DateTime? NgayTra { get; set; }
        [Column(TypeName = "money")]
        public decimal? PhiCuoc { get; set; }
        [Column(TypeName = "money")]
        public decimal? PhiPhong { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual Phong? Phong { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}