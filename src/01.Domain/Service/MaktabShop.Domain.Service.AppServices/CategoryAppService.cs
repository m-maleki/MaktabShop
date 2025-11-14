using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Contracts.Services;
using MaktabShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabShop.Domain.Service.AppServices
{
    public class CategoryAppService (ICategoryService categoryService) : ICategoryAppService
    {
        public List<Category> GetCategories()
        {
            return categoryService.GetCategories();
        }
    }
}
