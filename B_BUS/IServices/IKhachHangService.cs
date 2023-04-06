using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IKhachHangService
    {
        bool Add(KhachHangViewModel obj); 
        bool Update(KhachHangViewModel obj); 
        bool Delete(Guid id); 
        List<KhachHangViewModel>? GetAll(); 
        KhachHangViewModel? GetByID(Guid id);
    }
}