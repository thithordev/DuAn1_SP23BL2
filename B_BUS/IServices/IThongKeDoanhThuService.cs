using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IThongKeDoanhThuService
    {
        bool Add(ThongKeDoanhThuViewModel obj); 
        bool Update(ThongKeDoanhThuViewModel obj); 
        bool Delete(Guid id); 
        List<ThongKeDoanhThuViewModel>? GetAll(); 
        List<ThongKeDoanhThuViewModel>? GetAllActive(); 
        ThongKeDoanhThuViewModel? GetByID(Guid id);
    }
}