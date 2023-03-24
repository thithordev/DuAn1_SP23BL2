using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    [Table("PhieuDichVu")]
    public class PhieuDichVu
    {
<<<<<<< HEAD
        [Key]
        public Guid IdPhieuDichVu { get; set; }
        [ForeignKey("KhachHangId")]
        public Guid? KhachHangId { get; set; }
        [ForeignKey("NhanVienId")]
        public  Guid? NhanVienId { get; set; } 
        public int? TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }  
        public virtual List<ChiTietPhieuDichVu>? ChiTietPhieuDichVus { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
=======
        public Guid Id { get; set; }    
        public Guid IdKH { get; set; }
        public  Guid IdNV { get; set; } 
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }  
        public virtual List<ChiTietPhieuSanPham> ChiTietPhieuDichVu { get; set; }
>>>>>>> 6d21da73cb0b50f32a8f4b2b4abaf159c4c4acb0
    }
}
