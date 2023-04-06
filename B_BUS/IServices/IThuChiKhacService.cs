using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IThuChiKhacService
    {
        bool Add(ThuChiKhacViewModel obj); 
        bool Update(ThuChiKhacViewModel obj); 
        bool Delete(Guid id); 
        List<ThuChiKhacViewModel>? GetAll(); 
        ThuChiKhacViewModel? GetByID(Guid id);
    }
}