using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("YeuCau")]
    public class YeuCau
    {
        [Key]
        public Guid IdYeuCau { get; set; }
        [ForeignKey("NhanVienId")]
        public Guid? NhanVienId { get; set; }
        [Column(TypeName = "ntext")]
        public string? Noidung { get; set; }
        [Column(TypeName = "money")]
        public decimal? ChiPhi { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public int? TrangThai { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
