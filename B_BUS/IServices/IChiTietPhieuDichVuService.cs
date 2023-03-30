using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChiTietPhieuDichVuService
    {
        string Add(ChiTietPhieuDichVuViewModel obj);
        string Update(ChiTietPhieuDichVuViewModel obj);
        string Delete(ChiTietPhieuDichVuViewModel obj);
        List<ChiTietPhieuDichVuViewModel> GetAll();
        ChiTietPhieuDichVuViewModel GetByID(Guid id);
    }
}
