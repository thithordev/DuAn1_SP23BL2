using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("Phong")]
    public class Phong : BaseModel
    {
        public Guid? LoaiPhongId { get; set; }
        public string? Ten { get; set; }
        public int TrangThai { get; set; }
        public int Tang { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        [ForeignKey("LoaiPhongId")]
        public virtual LoaiPhong? LoaiPhong { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
    }
}
