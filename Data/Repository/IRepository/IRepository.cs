using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
       Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
            );

        Task<T>FirstOrDefaultAsyn(
            Expression<Func<T, bool>> filter = null
            );

        Task<List<T>> ToListAsync();
        Task AddAsync(T entity);
        void Remove(int id);
        void Remove(T entity);
    }
}
