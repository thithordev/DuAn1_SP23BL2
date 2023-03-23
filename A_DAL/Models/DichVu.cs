using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class DichVu
    {
        public Guid id { get; set; }
        public string tenDV { get; set; }
        public float giaDV { get; set; }
        public virtual List<ChiTietPhieuSanPham> chiTiletPhieuDV { get; set; }
    }
}
