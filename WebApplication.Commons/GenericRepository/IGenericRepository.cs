using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApplication.Commons.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> GetAsync(Expression<Func<T, bool>> getBy);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> AddAsync(T entity);
        public Task DeleteAsync(Expression<Func<T, bool>> getBy);
        public Task<T> UpdateAsync(T entity);
    }
}
