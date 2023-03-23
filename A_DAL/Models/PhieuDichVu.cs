using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class PhieuDichVu
    {
        public Guid id { get; set; }    
        public Guid idKH { get; set; }
        public  Guid idNV { get; set; } 
        public string trangThai { get; set; }
        public string ghiChu { get; set; }  
        public virtual List<ChiTietPhieuSanPham> chiTietPhieuDichVu { get; set; }
    }
}
