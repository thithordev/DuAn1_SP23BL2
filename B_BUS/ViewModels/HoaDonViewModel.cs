using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class HoaDonViewModel : HoaDon
    {
        public Guid Hoadon { get; set; }
        public string Khachhang { set; get; }
        public int sdt { set; get; }
        public DateTime DateTime { set; get; }
        public int phuongthucthanhtoan { set; get; }
        public int Tongsotien { set; get; }
        public int trangthai { set; get; }
    }
}
