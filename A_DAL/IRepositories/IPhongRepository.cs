using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IPhongRepository
    {
        bool Add(Phong obj); 
        bool Update(Phong obj);
        bool Delete(Phong obj);
        List<Phong> GetAll();
        Phong GetByID(Guid id);
    }
}
