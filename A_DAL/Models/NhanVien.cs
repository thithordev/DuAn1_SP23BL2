using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class NhanVien
    {
        public Guid Id { get; set; }
        public Guid IDChucVu { get; set; }
        public Guid IDCapTren { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgSinh { get; set; }
        public int TrangThai { get; set; }
        public string MatKhau { get; set; }
        public int Luong { get; set; }
        public string? GhiChu { get; set; }
    }
}
