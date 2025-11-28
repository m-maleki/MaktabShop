using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Infrastructure.EfCore.common;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace MaktabShop.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository (AppDbContext dbContext) : ICategoryRepository
    {
        public async Task<List<Category>> GetCategories(CancellationToken cancellationToken)
        {
            return await dbContext.Categories.ToListAsync(cancellationToken);
        }
    }
}
