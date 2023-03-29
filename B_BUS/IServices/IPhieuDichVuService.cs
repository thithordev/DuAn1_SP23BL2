using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IPhieuDichVuService
    {
        string Add(PhieuDichVuViewModel obj);
        string Update(PhieuDichVuViewModel obj);
        string Delete(PhieuDichVuViewModel obj);
        List<PhieuDichVuViewModel>? GetAll();
        PhieuDichVuViewModel? GetByID(Guid id);
    }
}