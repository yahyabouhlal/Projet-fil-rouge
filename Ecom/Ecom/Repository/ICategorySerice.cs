using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Repository
{
    interface ICategorySerice
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
        Task CreateCategory(Category category);
        Task DeleteCategory(Category category);
        Task UpdateCategory(Category category, Category dbCategory);
    }
}
}
