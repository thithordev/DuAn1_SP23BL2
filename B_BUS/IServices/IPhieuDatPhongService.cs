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
        bool Add(PhieuDatPhongViewModel obj); 
        bool Update(PhieuDatPhongViewModel obj); 
        bool Delete(Guid id); 
        List<PhieuDatPhongViewModel>? GetAll(); 
        List<PhieuDatPhongViewModel>? GetAllActive(); 
        PhieuDatPhongViewModel? GetByID(Guid id);
    }
}