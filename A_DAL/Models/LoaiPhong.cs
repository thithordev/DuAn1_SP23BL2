using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("LoaiPhong")]
    public class LoaiPhong
    {
        [Key]
        public Guid IdLoaiPhong { get; set; }
        public string? Ten { get; set; }
        [Column(TypeName = "ntext")]
        public string? Mota { get; set; }
        public int? SoGiuong { get; set; }
        [Column(TypeName = "money")]
        public decimal? GiaNgay { get; set; }
        [Column(TypeName = "money")]
        public decimal? GiaPhong { get; set; }
        public virtual List<Phong>? Phongs { get; set; }
    }
}
