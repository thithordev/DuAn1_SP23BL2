using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class ChiTietPhieuDichVuViewModel : ChiTietPhieuDichVu
    {
        public ChiTietPhieuDichVu ChiTietPhieuDichVu { get; set; }
        public DichVu DichVu { get; set; }
        public PhieuDichVu phieuDichVu { get; set; }
    }
}
