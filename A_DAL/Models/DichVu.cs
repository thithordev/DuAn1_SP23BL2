using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("DichVu")]
    public class DichVu
    {
<<<<<<< HEAD
        [Key]
        public Guid IdDichVu { get; set; }
        public string? Ten { get; set; }
        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }
        public virtual List<ChiTietPhieuDichVu>? ChiTietPhieuDichVus { get; set; }


        public void InRaManHinh()
        {
            Console.WriteLine($"{IdDichVu} - {Ten} - {Gia}");
        }
=======
        public Guid Id { get; set; }
        public string TenDV { get; set; }
        public float GiaDV { get; set; }
        public virtual List<ChiTietPhieuSanPham> ChiTiletPhieuDV { get; set; }
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0
    }
}
