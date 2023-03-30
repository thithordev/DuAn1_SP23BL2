using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IDichVuService
    {
        string Add(DichVuViewModel obj);
        string Update(DichVuViewModel obj);
        string Delete(DichVuViewModel obj);
        List<DichVuViewModel> GetAll();
        DichVuViewModel GetByID(Guid id);
    }
}