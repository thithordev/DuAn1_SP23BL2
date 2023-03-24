using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class ChiTietPhieuSanPham
    {
        public Guid Id { get; set; }
        public Guid IdDV { get; set; }
        public Guid IdPDV { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }

        public virtual DichVu DichVu { get; set; }
        public virtual PhieuDichVu PhieuDichVu { get; set; }
    }
}
