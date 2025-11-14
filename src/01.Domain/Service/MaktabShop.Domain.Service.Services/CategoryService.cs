using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Service.Services
{
    public class CategoryService (ICategoryRepository categoryRepository) : ICategoryService
    {
        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }
    }
}
