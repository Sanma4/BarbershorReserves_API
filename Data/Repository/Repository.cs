using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        internal DbSet<T> _dbSet;


        public async Task<T> GetAsync(int id)
        {
           return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T>  query = _dbSet;
            if (filter != null)
            {
                query.Where(filter);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return await query.ToListAsync();
        }

        public async Task<T> FirstOrDefaultAsyn(Expression<Func<T, bool>> filter = null)
        {
             IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> ToListAsync()
        {
            IQueryable<T> query = _dbSet;
           
            return await query.ToListAsync(); 
        }

        public async void AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
        }
        public void Remove(int id)
        {
            T entityToRemove = _dbSet.Find(id);
        }

    }
}
