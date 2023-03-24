using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("Phong")]
    public class Phong
    {
        [Key]
        public Guid IdPhong { get; set; }
        [ForeignKey("LoaiPhongId")]
        public Guid? LoaiPhongId { get; set; }
        public string? Ten { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual LoaiPhong? LoaiPhong { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
    }
}
