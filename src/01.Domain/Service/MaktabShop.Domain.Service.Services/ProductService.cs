using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;
using System.Threading.Tasks;

namespace MaktabShop.Domain.Service.Services
{

    public class ProductService (IProductRepository productRepository) : IProductService
    {
        public async Task Create(Product product,CancellationToken cancellationToken)
        {
           await productRepository.Create(product, cancellationToken);
        }

        public async Task Delete(int productId,CancellationToken cancellationToken)
        {
           await productRepository.Delete(productId, cancellationToken);
        }

        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        {
           return await productRepository.GetAll(cancellationToken);
        }

        public async Task<Product> GetById(int productId,CancellationToken cancellationToken)
        {
            return await productRepository.GetById(productId, cancellationToken);
        }

        public async Task Update(Product product,CancellationToken cancellationToken)
        {
          await  productRepository.Update(product, cancellationToken);
        }
    }
}
