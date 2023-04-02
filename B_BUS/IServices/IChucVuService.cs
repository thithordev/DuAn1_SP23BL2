using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChucVuService
    {
        bool Add(ChucVuViewModel obj);
        bool Update(ChucVuViewModel obj);
        bool Delete(Guid id);
        List<ChucVuViewModel>? GetAll();
        List<ChucVuViewModel>? GetAllActive();
        ChucVuViewModel? GetByID(Guid id);
    }
}