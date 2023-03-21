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
        public string ten { get; set; }
        public string SDT { get; set; }
        public string diaChi { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngSinh { get; set; }
        public int trangThai { get; set; }
        public string Password { get; set; }
        public int Luong { get; set; }
        public string? note { get; set; }
    }
}
