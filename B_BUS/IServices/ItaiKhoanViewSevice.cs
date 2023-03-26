using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ItaiKhoanViewSevice
    {
        string Create(TaiKhoanView taiKhoanView);
        string Update(TaiKhoanView taiKhoanView);
        string Delete(TaiKhoanView taiKhoanView);
        //SanPhamView timkiem(string ten);
        List<TaiKhoanView> GetAll();
    }
}
