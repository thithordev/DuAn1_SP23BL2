using A_DAL.Context;
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
    public class YeuCauService : IYeuCauService
    {
        public string Add(YeuCauViewModel obj)
        {
            bool kq = YeuCauDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(YeuCauViewModel obj)
        {
            var kq = YeuCauDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<YeuCauViewModel> GetAll()
        {
            return YeuCauDataProvider.Ins.repository.GetAll().ConvertAll(x => YeuCauDataProvider.Ins.convertToVM(x));
        }

        public YeuCauViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new YeuCauViewModel();
            return YeuCauDataProvider.Ins.convertToVM(YeuCauDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(YeuCauViewModel obj)
        {
            var kq = YeuCauDataProvider.Ins.repository.Update(obj);
            if (kq)
            {
                return "Cập nhật thành công!";
            }
            else
            {
                return "Cập nhật thất bại!";
            }
        }
    }
}
