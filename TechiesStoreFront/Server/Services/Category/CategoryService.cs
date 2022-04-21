using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.CategoryModels;

namespace TechiesStoreFront.Server.Services.Category
{
    public class CategoryService : ICategoryService
    {
        public Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDetail> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(CategoryEdit model)
        {
            throw new NotImplementedException();
        }
    }
}
