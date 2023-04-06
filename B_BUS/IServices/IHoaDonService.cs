using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoaDonService
    {
        bool Add(HoaDonViewModel obj);
        bool Update(HoaDonViewModel obj);
        bool Delete(Guid id);
        List<HoaDonViewModel>? GetAll();
        HoaDonViewModel? GetByID(Guid id);
    }
}