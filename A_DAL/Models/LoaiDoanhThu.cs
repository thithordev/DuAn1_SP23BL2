using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("LoaiDoanhThu")]
    public class LoaiDoanhThu : BaseModel
    {
        [Key]
        public Guid IDLoaiDoanhThu { get;set; }
        public string? Ten { get;set; }
        public bool? Kieu { get;set; }
        public virtual List<ThongKeDoanhThu>? ThongKeDoanhThus { get; set; }
    }
}
