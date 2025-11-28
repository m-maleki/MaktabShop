using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.AppServices
{
    public interface IProductAppService
    {
        public Task Create(Product product,CancellationToken cancellationToken);
        public Task Update(Product productc,CancellationToken cancellationToken);
        public Task Delete(int productId,CancellationToken cancellationToken);
        public Task<Product> GetById(int productId,CancellationToken cancellationToken);
        public Task<List<Product>> GetAll(CancellationToken cancellationToken);
    }
}
