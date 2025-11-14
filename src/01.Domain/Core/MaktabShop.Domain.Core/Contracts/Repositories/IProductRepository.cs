using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.Repositories
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public void Update(Product product);
        public void Delete(int productId);
        public Product GetById(int productId);
        public List<Product> GetAll();
    }
}
