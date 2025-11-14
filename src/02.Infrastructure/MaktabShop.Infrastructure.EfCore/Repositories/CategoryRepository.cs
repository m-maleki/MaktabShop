using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Infrastructure.EfCore.common;


namespace MaktabShop.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository (AppDbContext dbContext) : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
    }
}
