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
        bool Add(PhieuDatPhong phieuDatPhong);
        bool Update(PhieuDatPhong phieuDatPhong);
        bool Delete(PhieuDatPhong phieuDatPhong);
        List<PhieuDatPhong> GetAll();
        PhieuDatPhong GetByID(Guid id);
    }
}
