using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ILoaiPhongRepository
    {
        bool Add(LoaiPhong obj);
        bool Update(LoaiPhong obj);
        bool Delete(Guid id);
        List<LoaiPhong>? GetAll();
        List<LoaiPhong>? GetAllActive();
        LoaiPhong? GetByID(Guid id);
    }
}
