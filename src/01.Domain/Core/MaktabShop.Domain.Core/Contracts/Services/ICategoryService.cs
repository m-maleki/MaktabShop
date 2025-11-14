using MaktabShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabShop.Domain.Core.Contracts.Services
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();

    }
}
