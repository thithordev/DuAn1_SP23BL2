using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("ChucVu")]
    public class ChucVu
    {
        [Key]
        public Guid IDChucVu { get; set; }
        public string? Ten { get; set; }
        public string? QuyenTruyCap { get; set; }
        public virtual List<NhanVien>? NhanViens { get; set; }
    }
}
