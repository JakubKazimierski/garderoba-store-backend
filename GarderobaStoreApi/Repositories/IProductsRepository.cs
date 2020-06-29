using GarderobaStoreApi.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Repositories
{
    interface IProductsRepository :IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<IEnumerable<Product>> GetAllProductsByCategory(int categoryId);
    }
}
