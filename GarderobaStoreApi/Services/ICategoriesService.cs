using GarderobaStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Services
{
   public interface ICategoriesService
    {
        Task<IEnumerable<Category>> GetAllCategories();

        Task<Category> AddCategory(Category category);

    }
}
