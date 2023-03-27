using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IPhieuDatPhongService
    {
        string Add(PhieuDatPhongViewModel obj);
        string Update(PhieuDatPhongViewModel obj);
        string Delete(PhieuDatPhongViewModel obj);
        List<PhieuDatPhongViewModel>? GetAll();
        PhieuDatPhongViewModel? GetByID(Guid id);
    }
}