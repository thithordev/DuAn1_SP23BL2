using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class KhachHang
    {
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public virtual List<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
        public virtual List<PhieuDichVu> PhieuDichVus { get; set; }

    }
}
