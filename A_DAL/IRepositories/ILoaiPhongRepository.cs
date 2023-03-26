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
        bool Delete(LoaiPhong obj);
        List<LoaiPhong>? GetAll();
        LoaiPhong? GetByID(Guid id);
    }
}
