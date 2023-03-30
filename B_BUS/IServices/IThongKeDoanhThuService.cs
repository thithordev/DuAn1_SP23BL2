using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IThongKeDoanhThuService
    {
        string Add(ThongKeDoanhThuViewModel obj);
        string Update(ThongKeDoanhThuViewModel obj);
        string Delete(ThongKeDoanhThuViewModel obj);
        List<ThongKeDoanhThuViewModel> GetAll();
        ThongKeDoanhThuViewModel GetByID(Guid id);
    }
}