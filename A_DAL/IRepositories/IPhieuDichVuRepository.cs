using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IPhieuDichVuRepository
    {
        bool Add(PhieuDichVu obj);
        bool Update(PhieuDichVu obj);
        bool Delete(PhieuDichVu obj);
        List<PhieuDichVu> GetAll();
        PhieuDichVu GetByID(Guid id);
    }
}
