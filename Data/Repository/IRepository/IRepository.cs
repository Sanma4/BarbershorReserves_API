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
        T Task<GetAsync>(int id);
        IEnumerable<T> Task<GetAll>(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
            );

        T Task<FirstOrDefaultAsyn>(
            Expression<Func<T, bool>> filter = null
            );

        List<T> Task<ToListAsync>();
        void Task<AddAsync>(T entity);
        void Remove(int id);
    }
}
