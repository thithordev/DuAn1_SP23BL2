using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IYeuCauService
    {
        bool Add(YeuCauViewModel obj); 
        bool Update(YeuCauViewModel obj); 
        bool Delete(Guid id); 
        List<YeuCauViewModel>? GetAll(); 
        List<YeuCauViewModel>? GetAllActive(); 
        YeuCauViewModel? GetByID(Guid id);
    }
}