using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("DichVu")]
    public class DichVu : BaseModel
    {
        public string? Ten { get; set; }
        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }
        public bool? TrangThai { get; set; }
        public virtual List<ChiTietPhieuDichVu>? ChiTietPhieuDichVus { get; set; }


        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} - {Ten} - {Gia}");
        }
    }
}
