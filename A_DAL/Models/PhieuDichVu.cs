using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class PhieuDichVu
    {
        public Guid Id { get; set; }    
        public Guid IdKH { get; set; }
        public  Guid IdNV { get; set; } 
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }  
        public virtual List<ChiTietPhieuSanPham> ChiTietPhieuDichVu { get; set; }
    }
}
