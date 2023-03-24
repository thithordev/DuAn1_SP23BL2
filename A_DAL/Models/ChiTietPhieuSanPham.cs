using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class ChiTietPhieuSanPham
    {
        public Guid id { get; set; }
        public Guid idDV { get; set; }
        public Guid idPDV { get; set; }
        public int soLuong { get; set; }
        public float donGia { get; set; }

        public virtual DichVu DichVu { get; set; }
        public virtual PhieuDichVu PhieuDichVu { get; set; }

    }
}
