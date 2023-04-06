using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IPhongService
    {
        bool Add(PhongViewModel obj); 
        bool Update(PhongViewModel obj); 
        bool Delete(Guid id); 
        List<PhongViewModel>? GetAll(); 
        PhongViewModel? GetByID(Guid id);
    }
}