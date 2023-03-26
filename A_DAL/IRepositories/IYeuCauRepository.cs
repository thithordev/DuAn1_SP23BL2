using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IYeuCauRepository
    {
        bool Add(YeuCau obj);
        bool Update(YeuCau obj);
        bool Delete(YeuCau obj);
        List<YeuCau>? GetAll();
        YeuCau? GetByID(Guid id);
    }
}
