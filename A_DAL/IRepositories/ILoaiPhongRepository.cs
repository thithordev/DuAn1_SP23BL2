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
        bool Add(LoaiPhong loaiPhong);
        bool Update(LoaiPhong loaiPhong);
        bool Delete(LoaiPhong loaiPhong);
        List<LoaiPhong> GetAll();
        LoaiPhong GetByID(Guid id);
    }
}
