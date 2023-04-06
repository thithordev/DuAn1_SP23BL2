using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("KhachHang")]
    public class KhachHang : BaseModel
    {
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? CCCD { get; set; }
        public string? SDT { get; set; }
        public bool? GioiTinh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
        public virtual List<HoaDon>? HoaDons { get; set; }

    }
}
