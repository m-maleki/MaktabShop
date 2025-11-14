using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;

namespace MaktabShop.Domain.Service.AppServices
{
    public class ProductAppService (IProductService productService) : IProductAppService
    {
        public void Create(Product product)
        {
            productService.Create(product);
        }

        public void Delete(int productId)
        {
            productService.Delete(productId);
        }

        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        public Product GetById(int productId)
        {
            return productService.GetById(productId);
        }

        public void Update(Product product)
        {
            productService.Update(product);
        }
    }
}
