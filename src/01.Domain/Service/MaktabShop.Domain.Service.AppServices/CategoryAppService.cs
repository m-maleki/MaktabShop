using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaktabShop.Domain.Service.AppServices
{
    public class CategoryAppService (ICategoryService categoryService) : ICategoryAppService
    {
        public async Task<List<Category>> GetCategories(CancellationToken cancellationToken)
        {
            return await categoryService.GetCategories(cancellationToken);
        }
    }
}
