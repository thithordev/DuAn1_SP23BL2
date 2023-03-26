using A_DAL.Models;
using B_BUS.BaseViewModel;
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
        public decimal? TongTien
        {
            get
            {
                return this.SoLuong * this.DonGia;
            }
        }
    }
}
