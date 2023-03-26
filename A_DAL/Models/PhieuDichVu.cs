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
    public class PhieuDichVu : BaseModel
    {
        [Key]
        public Guid IdPhieuDichVu { get; set; }
        [ForeignKey("KhachHangId")]
        public Guid? KhachHangId { get; set; }
        [ForeignKey("NhanVienId")]
        public  Guid? NhanVienId { get; set; }
        [ForeignKey("PhieuDatPhongId")]
        public Guid? PhieuDatPhongId { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }  
        public virtual List<ChiTietPhieuDichVu>? ChiTietPhieuDichVus { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
        public virtual PhieuDatPhong? PhieuDatPhong { get; set; }
    }
}
