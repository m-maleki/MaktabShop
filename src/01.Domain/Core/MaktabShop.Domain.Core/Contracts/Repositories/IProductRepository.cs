using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.Repositories
{
    public interface IProductRepository
    {
        public Task Create(Product product,CancellationToken cancellationToken);
        public Task Update(Product product, CancellationToken cancellationToken);
        public Task Delete(int productId,CancellationToken cancellationToken);
        public Task<Product> GetById(int productId,CancellationToken cancellationToken);
        public Task<List<Product>> GetAll(CancellationToken cancellationToken);
    }
}
