using GarderobaStoreApi.Models;
using GarderobaStoreApi.Repositories;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarderobaStoreApi.Services
{
    public class CategoriesService : ICategoriesService
    {
        private ICategoriesRepository _categoriesRepo;
        public CategoriesService(ICategoriesRepository categoriesRepo)
        {
            _categoriesRepo = categoriesRepo;
        }
        public async Task<Category> AddCategory(Category category)
        {
            var checkCategory = await _categoriesRepo.CheckCategory(category);

            if (checkCategory)
            {
                await _categoriesRepo.Add(category);
                await _categoriesRepo.SaveAsync();
                return category;
            }
            
            return null;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoriesRepo.GetAllCategories();
        }
    }
}
