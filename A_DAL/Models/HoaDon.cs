using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("HoaDon")]
    public class HoaDon : BaseModel
    {
        public Guid? KhachHangId { get; set; }
        public Guid? NhanVienId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        [ForeignKey("KhachHangId")]
        public virtual KhachHang? KhachHang { get; set; }
        [ForeignKey("NhanVienId")]
        public virtual NhanVien? NhanVien { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
    }
}
