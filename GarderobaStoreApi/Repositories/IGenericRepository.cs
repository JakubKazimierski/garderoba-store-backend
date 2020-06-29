using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<ICollection<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        void Update(T entity);
        Task SaveAsync();
        void Delete(int id);


}
}
