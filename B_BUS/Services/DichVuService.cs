using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class DichVuService : IDichVuService
    {
        IDichVuRepository _dichVu;
        public DichVuService()
        {
            _dichVu = new DichVuRepository();
        }
        public string Add(DichVuViewModel obj)
        {
            bool kq = DichVuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(DichVuViewModel obj)
        {
            
                if (obj == null) return "Delete thất bại";
                var dt = _dichVu.GetAll().FirstOrDefault(p => p.IdDichVu == obj.IdDichVu);
                if (dt != null)
                {
                    _dichVu.Delete(dt);
                    return "Delete thành công";
                }
                return "Delete thất bại";
            
        }
        public List<DichVuViewModel> GetAll()
        {
            return DichVuDataProvider.Ins.repository.GetAll().ConvertAll(x => DichVuDataProvider.Ins.convertToVM(x));
        }

        public DichVuViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new DichVuViewModel();
            return DichVuDataProvider.Ins.convertToVM(DichVuDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(DichVuViewModel obj)
        {
            if (obj == null) return "update thất bại";
            var dt = _dichVu.GetAll().FirstOrDefault(p => p.IdDichVu == obj.IdDichVu);
            if (dt != null)
            {
                dt.Ten = obj.Ten;
                dt.Gia = obj.Gia;
                _dichVu.Update(dt);
                return "update thành công"; 
            }
            return "update thất bại";
        }
    }
}
