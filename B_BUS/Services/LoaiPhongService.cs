using A_DAL.Context;
using A_DAL.Models;
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
    public class LoaiPhongService : ILoaiPhongService
    {
        #region CRUD
        public bool Add(LoaiPhongViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = LoaiPhongDataProvider.Ins.convertToM(obj);
            bool kq = LoaiPhongDataProvider.Ins.repository.Add(objIsModel);
            if(kq) return true; 
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = LoaiPhongDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<LoaiPhongViewModel>? GetAll()
        {
            var lst = LoaiPhongDataProvider.Ins.repository.GetAll().ToList();
            if(lst == null) return null;
            return lst.ConvertAll( p => LoaiPhongDataProvider.Ins.convertToVM(p));
        }

        public List<LoaiPhongViewModel>? GetAllActive()
        {
            var lst = LoaiPhongDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => LoaiPhongDataProvider.Ins.convertToVM(p));
        }

        public LoaiPhongViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = LoaiPhongDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null; 
            return LoaiPhongDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(LoaiPhongViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = LoaiPhongDataProvider.Ins.convertToM(obj);
            bool kq = LoaiPhongDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}

