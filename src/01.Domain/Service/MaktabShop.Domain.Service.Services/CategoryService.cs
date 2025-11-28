using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;
using System.Threading.Tasks;

namespace MaktabShop.Domain.Service.Services
{
    public class CategoryService (ICategoryRepository categoryRepository) : ICategoryService
    {
        public async Task<List<Category>> GetCategories(CancellationToken cancellationToken)
        {
            return await categoryRepository.GetCategories(cancellationToken);
        }
    }
}
