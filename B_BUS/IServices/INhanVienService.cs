using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface INhanVienService
    {
        bool Add(NhanVienViewModel obj); 
        bool Update(NhanVienViewModel obj); 
        bool Delete(Guid id); 
        List<NhanVienViewModel>? GetAll(); 
        List<NhanVienViewModel>? GetAllActive(); 
        NhanVienViewModel? GetByID(Guid id);
        NhanVienViewModel? GetLogin(string username, string password);
    }
}