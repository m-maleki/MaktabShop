using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}
