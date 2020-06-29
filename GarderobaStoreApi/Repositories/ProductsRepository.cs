using GarderobaStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private StoreContext _context;

        public ProductsRepository(StoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.Include(c => c.Category).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsByCategory(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).Include(c => c.Category).ToListAsync();
        }
    }
}
