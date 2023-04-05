using A_DAL.Context;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhaNghiRepository<T> : INhaNghiRepository<T> where T : class, IEntity, new()
    {
        public bool Add(T obj)
        {
            try
            {
                if (obj.Id != Guid.Empty) return false;
                DataProvider.Ins.dbContext.Set<T>().Add(obj);
                var count = DataProvider.Ins.dbContext.SaveChanges();
                if(count == 0) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                if (id == Guid.Empty) return false;
                var T = GetByID(id);
                if (T == null) return false;
                T.IsDeleted = true;
                var kq = Update(T);
                if(!kq) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IQueryable<T> GetAll()
        {
            return DataProvider.Ins.dbContext.Set<T>();
        }

        public IQueryable<T> GetAllActive()
        {
            return DataProvider.Ins.dbContext.Set<T>().Where((p) => p.IsDeleted == false);
        }

        public T? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.Set<T>().Find(id);
        }

        public bool Update(T obj)
        {
            try
            {
                var T = GetByID(obj.Id);
                if(T == null) return false;
                var entry = DataProvider.Ins.dbContext.Entry(T);
                entry.CurrentValues.SetValues(obj);
                entry.State = EntityState.Modified;
                var count = DataProvider.Ins.dbContext.SaveChanges();
                if (count == 0) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
