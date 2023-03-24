using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IChiTietPhieuDichVuRepository
    {
        bool Add(ChiTietPhieuDichVu obj);
        bool Update(ChiTietPhieuDichVu obj);
        bool Delete(ChiTietPhieuDichVu obj);
        List<ChiTietPhieuDichVu> GetAll();
        ChiTietPhieuDichVu GetByID(Guid id);
    }
}
