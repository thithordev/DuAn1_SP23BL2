using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IPhieuDatPhongRepository
    {
        bool Add(PhieuDatPhong obj);
        bool Update(PhieuDatPhong obj);
        bool Delete(PhieuDatPhong obj);
        List<PhieuDatPhong>? GetAll();
        PhieuDatPhong? GetByID(Guid id);
    }
}
