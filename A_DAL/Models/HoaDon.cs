using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class HoaDon
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int PhuongThucThanhToan { get; set; }
        public string GhiChu { get; set; }

        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        ///public List<ChiTietPhieuDichVu> chiTietPhieuDichVus { get;set }
    }
}
