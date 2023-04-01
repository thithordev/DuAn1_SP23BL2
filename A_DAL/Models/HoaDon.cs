using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        [ForeignKey("KhachHangId")]
        public Guid? KhachHangId { get; set; }
        [ForeignKey("NhanVienId")]
        public Guid? NhanVienId { get; set; }
        public DateTime? NgayTao { get; set; }
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
        public virtual List<PhieuDichVu>? PhieuDichVus { get; set; }
    }
}
