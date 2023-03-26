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
        string Add(ChucVuViewModel obj);
        string Update(ChucVuViewModel obj);
        string Delete(ChucVuViewModel obj);
        List<ChucVuViewModel>? GetAll();
        ChucVuViewModel? GetByID(Guid id);
    }
}