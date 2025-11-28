using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategories(CancellationToken cancellationToken);
    }
}
