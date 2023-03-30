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
        string Add(KhachHangViewModel obj);
        string Update(KhachHangViewModel obj);
        string Delete(KhachHangViewModel obj);
        List<KhachHangViewModel> GetAll();
        KhachHangViewModel GetByID(Guid id);
    }
}