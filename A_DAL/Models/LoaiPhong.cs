using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("LoaiPhong")]
    public class LoaiPhong : BaseModel
    {
        public string? Ten { get; set; }
        [Column(TypeName = "ntext")]
        public string? Mota { get; set; }
        public int? OToiDa { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNgay { get; set; }
        [Column(TypeName = "money")]
        public decimal? GiaGio { get; set; }
        [Column(TypeName = "money")]
        public decimal? GiaDem { get; set; }

        public virtual List<Phong>? Phongs { get; set; }
    }
}
