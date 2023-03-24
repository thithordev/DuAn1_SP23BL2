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
<<<<<<< HEAD
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
        ChucVu GetByID(Guid id);
=======
        bool Add(ChucVu ctsp);
        bool Update(ChucVu ctsp);
        bool Delete(ChucVu ctsp);
        ChucVu GetByID(Guid id);
        List<ChucVu> GetAll();
>>>>>>> df17d33fc9bbcfa53df09ff1035790784c2fe362
    }
}
