using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IChucVuRepository
    {
        bool Add(ChucVu ctsp);
        bool Update(ChucVu ctsp);
        bool Delete(ChucVu ctsp);
        ChucVu GetByID(Guid id);
        List<ChucVu> GetAll();
    }
}
