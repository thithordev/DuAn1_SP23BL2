using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("ThongKeDoanhThu")]
    public class ThongKeDoanhThu
    {
        [Key]
        public Guid IDThongKeDoanhThu { get; set; }
        [ForeignKey("LoaiDoanhThuId")]
        public Guid? LoaiDoanhThuId { get; set; }
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "ntext")]
        public string? NoiDung { get; set; }
        [Column(TypeName = "money")]
        public decimal? SoTien { get; set; }
        public virtual LoaiDoanhThu? LoaiDoanhThu { get; set; }
    }
}
