using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("ChucVu")]
    public class ChucVu : BaseModel
    {
        public string? Ten { get; set; }
        public string? QuyenTruyCap { get; set; }
        
        public virtual List<NhanVien>? NhanViens { get; set; }
    }
}
