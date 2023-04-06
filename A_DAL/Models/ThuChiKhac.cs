using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("ThuChiKhac")]
    public class ThuChiKhac : BaseModel
    {
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        public bool isThu { get; set; }
        // true: thu
        // false: chi
        [Column(TypeName = "ntext")]
        public string? NoiDung { get; set; }
        [Column(TypeName = "money")]
        public decimal? SoTien { get; set; }
    }
}
