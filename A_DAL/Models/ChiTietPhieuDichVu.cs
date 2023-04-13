using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("ChiTietPhieuDichVu")]
    public class ChiTietPhieuDichVu : BaseModel
    {
        public Guid? PhieuDichVuID { get; set; }
        public Guid? DichVuID { get; set; }
        public int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }
        [ForeignKey("PhieuDichVuID")]
        public virtual DichVu? DichVu { get; set; }
        [ForeignKey("DichVuID")]
        public virtual PhieuDichVu? PhieuDichVu { get; set; }
    }
}
