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
        string Add(NhanVienViewModel obj);
        string Update(NhanVienViewModel obj);
        string Delete(NhanVienViewModel obj);
        List<NhanVienViewModel> GetAll();
        NhanVienViewModel GetByID(Guid id);
        NhanVienViewModel GetLogin(string username, string password);
    }
}