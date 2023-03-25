using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("ChiTietPhieuDichVu")]
    public class ChiTietPhieuDichVu
    {
        [Key]
        public Guid IDChiTietPhieuDichVu { get; set; }
        [ForeignKey("PhieuDichVuID")]
        public Guid? PhieuDichVuID { get; set; }
        [ForeignKey("DichVuID")]
        public Guid? DichVuID { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public virtual DichVu? DichVu { get; set; }
        public virtual PhieuDichVu? PhieuDichVu { get; set; }
    }
}
