using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GarderobaStoreApi.Models;

namespace GarderobaStoreApi.Repositories
{
    public class GenericRepository : IGenericRepository<T> where T : class
    {
        private readonly StoreContext _context; 

        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<ICollection<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

    }
}
