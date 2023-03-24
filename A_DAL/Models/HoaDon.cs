using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
<<<<<<< HEAD
        public Guid IdHoaDon { get; set; }
        [ForeignKey("KhachHangId")]
        public Guid? KhachHangId { get; set; }
        [ForeignKey("NhanVienId")]
        public Guid? NhanVienId { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
        public List<PhieuDichVu>? PhieuDichVus { get; set; }
=======
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int PhuongThucThanhToan { get; set; }
        public string GhiChu { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        ///public List<ChiTietPhieuDichVu> ChiTietPhieuDichVus { get;set }
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0
    }
}
