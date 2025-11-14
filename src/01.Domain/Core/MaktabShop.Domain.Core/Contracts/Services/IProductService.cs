using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Core.Contracts.Services
{
    public interface IProductService
    {
        public void Create(Product product);
        public void Update(Product product);
        public void Delete(int productId);
        public Product GetById(int productId);
        public List<Product> GetAll();
    }
}
