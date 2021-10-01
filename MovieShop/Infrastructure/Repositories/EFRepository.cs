using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EFRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly MovieShopDbContext _movieShopDbContext;
        public EFRepository(MovieShopDbContext dbContext)
        {
            _movieShopDbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            var entity = await _movieShopDbContext.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            var data = await _movieShopDbContext.Set<T>().ToListAsync();
            return data;
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            var data = await _movieShopDbContext.Set<T>().Where(filter).ToListAsync();
            return data;
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return await _movieShopDbContext.Set<T>().Where(filter).CountAsync();
            }

            return await _movieShopDbContext.Set<T>().CountAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _movieShopDbContext.Set<T>().AddAsync(entity);
            await _movieShopDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _movieShopDbContext.Entry(entity).State = EntityState.Modified;
            await _movieShopDbContext.SaveChangesAsync();
            return entity;
        }

        // sync void
        // Task in async

        // sync int
        // Task<int>
        public async Task DeleteAsync(T entity)
        {
            _movieShopDbContext.Set<T>().Remove(entity);
            await _movieShopDbContext.SaveChangesAsync();
        }
    }
    }
