using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("ThongKeDoanhThu")]
    public class ThongKeDoanhThu : BaseModel
    {
        public Guid? LoaiDoanhThuId { get; set; }
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "ntext")]
        public string? NoiDung { get; set; }
        [Column(TypeName = "money")]
        public decimal? SoTien { get; set; }
        [ForeignKey("LoaiDoanhThuId")]
        public virtual LoaiDoanhThu? LoaiDoanhThu { get; set; }
    }
}
