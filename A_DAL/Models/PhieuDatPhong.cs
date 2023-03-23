using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{

    internal class DatPhong
    {
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public Guid IdPhong { get; set; }
        public DateOnly NgayDat { get; set; }
        public TimeOnly ThoiGianDat { get; set; }
        public DateOnly NgayNhan { get; set; }
        public DateOnly NgayTra { get; set; }
        public string? GhiChu { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }    
    }
}