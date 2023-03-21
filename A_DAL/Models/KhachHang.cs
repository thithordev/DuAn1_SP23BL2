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
        public string hoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string ghiChu { get; set; }
    }
}
