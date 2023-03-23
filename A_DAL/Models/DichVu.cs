using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class DichVu
    {
        public Guid Id { get; set; }
        public string TenDV { get; set; }
        public float GiaDV { get; set; }
        public virtual List<ChiTietPhieuSanPham> ChiTiletPhieuDV { get; set; }
    }
}
