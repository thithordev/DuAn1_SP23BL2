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
        bool Add(PhieuDichVuViewModel obj); 
        bool Update(PhieuDichVuViewModel obj); 
        bool Delete(Guid id); 
        List<PhieuDichVuViewModel>? GetAll(); 
        PhieuDichVuViewModel? GetByID(Guid id);
    }
}