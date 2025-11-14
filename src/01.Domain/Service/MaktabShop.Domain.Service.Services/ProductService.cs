using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Service.Services
{

    public class ProductService (IProductRepository productRepository) : IProductService
    {
        public void Create(Product product)
        {
            productRepository.Create(product);
        }

        public void Delete(int productId)
        {
            productRepository.Delete(productId);
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public Product GetById(int productId)
        {
            return productRepository.GetById(productId);
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }
    }
}
