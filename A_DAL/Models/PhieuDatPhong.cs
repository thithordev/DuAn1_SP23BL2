using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("PhieuDatPhong")]
    public class PhieuDatPhong : BaseModel
    {
        public Guid? KhachHangId { get; set; }
        public Guid? HoaDonId { get; set; }
        public Guid? NhanVienId { get; set; }
        public Guid? PhongId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayDat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayDatTra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTra { get; set; }
        public int? TrangThai { get; set; }

        // 0 : hủy
        // 1 : hoạt động


        public int? KieuDat { get; set; }

        // 0 : Đặt theo giờ
        // 1 : Đặt theo ngày
        // 2 : Đặt theo đêm

        [Column(TypeName = "money")]
        public decimal? PhiPhong { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        [ForeignKey("PhongId")]
        public virtual Phong? Phong { get; set; }
        [ForeignKey("NhanVienId")]
        public virtual NhanVien? NhanVien { get; set; }
        [ForeignKey("KhachHangId")]
        public virtual KhachHang? KhachHang { get; set; }
        [ForeignKey("HoaDonId")]
        public virtual HoaDon? HoaDon { get; set; }
        public virtual List<PhieuDichVu>? PhieuDichVus { get; set; }
    }
}