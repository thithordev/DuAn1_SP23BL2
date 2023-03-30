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
        string Add(PhongViewModel obj);
        string Update(PhongViewModel obj);
        string Delete(PhongViewModel obj);
        List<PhongViewModel> GetAll();
        PhongViewModel GetByID(Guid id);
    }
}