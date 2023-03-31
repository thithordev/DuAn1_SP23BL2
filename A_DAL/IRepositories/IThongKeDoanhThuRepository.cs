using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IThongKeDoanhThuRepository
    {
        bool Add(ThongKeDoanhThu obj);
        bool Update(ThongKeDoanhThu obj);
        bool Delete(ThongKeDoanhThu obj);
        List<ThongKeDoanhThu> GetAll(); 
        ThongKeDoanhThu GetByID(Guid id);
    }
}
