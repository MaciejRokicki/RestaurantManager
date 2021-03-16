using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Commons.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;

        public GenericRepository(DbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context
                .Set<T>()
                .AddAsync(entity);

            await context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> getBy)
        {
            T entity = await GetAsync(getBy);

            context
                .Set<T>()
                .Remove(entity);

            await context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> getBy) => await context.Set<T>().FirstOrDefaultAsync(getBy);

        public async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();

        public async Task<T> UpdateAsync(T entity)
        {
            context
                .Set<T>()
                .Update(entity);

            await context.SaveChangesAsync();

            return entity;
        }
    }
}
