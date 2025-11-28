using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Infrastructure.EfCore.common;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MaktabShop.Infrastructure.EfCore.Repositories
{
    public class ProductRepository(AppDbContext dbContext) : IProductRepository
    {
        public async Task Create(Product product,CancellationToken cancellationToken)
        {
            await dbContext.Products.AddAsync(product, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task Delete(int productId,CancellationToken cancellationToken)
        {
            await dbContext.Products.Where(x => x.Id == productId).ExecuteDeleteAsync(cancellationToken);
        }
        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        {
            return await dbContext.Products.Include(x => x.Category)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
        public async Task<Product?> GetById(int productId,CancellationToken cancellationToken)
        {
            return await dbContext.Products.Include(x => x.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == productId, cancellationToken);
        }
        public async Task Update(Product product,CancellationToken cancellationToken)
        {
            var entity = await dbContext.Products.FirstOrDefaultAsync(x => x.Id == product.Id, cancellationToken);

            if (entity is not null)
            {
                entity.Name = product.Name;
                entity.Description = product.Description;
                entity.Price = product.Price;
               await dbContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
