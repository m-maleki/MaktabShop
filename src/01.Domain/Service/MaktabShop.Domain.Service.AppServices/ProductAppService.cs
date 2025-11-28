using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;
using System.Threading.Tasks;

namespace MaktabShop.Domain.Service.AppServices
{
    public class ProductAppService(IProductService productService) : IProductAppService
    {
        public async Task Create(Product product, CancellationToken cancellationToken)
        {
            await productService.Create(product, cancellationToken);
        }

        public async Task Delete(int productId, CancellationToken cancellationToken)
        {
           await productService.Delete(productId, cancellationToken);
        }

        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        {
            return await productService.GetAll(cancellationToken);
        }

        public async Task<Product> GetById(int productId, CancellationToken cancellationToken)
        {
            return await productService.GetById(productId, cancellationToken);
        }

        public async Task Update(Product product, CancellationToken cancellationToken)
        {
            await productService.Update(product, cancellationToken);
        }
    }
}
