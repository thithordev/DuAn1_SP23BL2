using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class Phong
    {
        public Guid Id { get; set; }
        public Guid IdLoaiPhong { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }
}
