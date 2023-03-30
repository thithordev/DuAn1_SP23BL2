using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ILoaiPhongService
    {
        string Add(LoaiPhongViewModel obj);
        string Update(LoaiPhongViewModel obj);
        string Delete(LoaiPhongViewModel obj);
        List<LoaiPhongViewModel> GetAll();
        LoaiPhongViewModel GetByID(Guid id);
    }
}