using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ILoaiDoanhThuRepository
    {
        bool Add(LoaiDoanhThu obj);
        bool Update(LoaiDoanhThu obj);
        bool Delete(LoaiDoanhThu obj);
        List<LoaiDoanhThu>? GetAll();
        LoaiDoanhThu? GetByID(Guid id);
    }
}
