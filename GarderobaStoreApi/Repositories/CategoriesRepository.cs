using GarderobaStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Repositories
{
    public class CategoriesRepository : GenericRepository<Category>,ICategoriesRepository
    {
        private StoreContext _context;

        public CategoriesRepository(StoreContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<bool> CheckCategory(Category category)
        {
            return (!await _context.Categories.AnyAsync(c => c.Name == category.Name));
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
