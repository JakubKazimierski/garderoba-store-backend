using GarderobaStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Repositories
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Task<bool> CheckCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
