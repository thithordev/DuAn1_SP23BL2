using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("PhieuDichVu")]
    public class PhieuDichVu : BaseModel
    {
        public  Guid? NhanVienId { get; set; }
        public Guid? PhieuDatPhongId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        public int TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }  
        public virtual List<ChiTietPhieuDichVu>? ChiTietPhieuDichVus { get; set; }
        [ForeignKey("NhanVienId")]
        public virtual NhanVien? NhanVien { get; set; }
        [ForeignKey("PhieuDatPhongId")]
        public virtual PhieuDatPhong? PhieuDatPhong { get; set; }
    }
}
