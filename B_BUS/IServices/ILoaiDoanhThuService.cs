using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ILoaiDoanhThuService
    {
        bool Add(LoaiDoanhThuViewModel obj); 
        bool Update(LoaiDoanhThuViewModel obj); 
        bool Delete(Guid id); List<LoaiDoanhThuViewModel>? GetAll(); 
        List<LoaiDoanhThuViewModel>? GetAllActive(); 
        LoaiDoanhThuViewModel? GetByID(Guid id);
    }
}