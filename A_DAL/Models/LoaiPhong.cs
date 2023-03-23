using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class LoaiPhong
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int SoGiuong { get; set; }
        public long GiaNgay { get; set; }
        public long GiaPhong { get; set; }
        public virtual List<Phong> Phongs { get; set; }
    }
}
