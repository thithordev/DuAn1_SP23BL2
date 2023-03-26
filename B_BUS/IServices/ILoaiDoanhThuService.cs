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
        string Add(LoaiDoanhThuViewModel obj);
        string Update(LoaiDoanhThuViewModel obj);
        string Delete(LoaiDoanhThuViewModel obj);
        List<LoaiDoanhThuViewModel>? GetAll();
        LoaiDoanhThuViewModel? GetByID(Guid id);
    }
}