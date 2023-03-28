using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj); 
        bool Delete(HoaDon obj); 
        List<HoaDon>? GetAll(); 
        HoaDon? GetByID(Guid id);
    }
}
