using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IDichVuRepository
    {
        bool Add(DichVu obj);
        bool Update(DichVu obj);
        bool Delete(DichVu obj);
        List<DichVu> GetAll(); 
        DichVu GetByID(Guid id);
    }
}
