using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public interface INhaNghiRepository<T> where T : class, IEntity, new()
    {
        public bool Add(T obj);
        public bool Update(T obj);
        public bool Delete(Guid id);
        public IQueryable<T> GetAll();
        public IQueryable<T> GetAllActive();
        public T? GetByID(Guid id);
    }
}
