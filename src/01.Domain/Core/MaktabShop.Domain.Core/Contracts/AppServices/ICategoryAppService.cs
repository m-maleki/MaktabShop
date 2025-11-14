using MaktabShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabShop.Domain.Core.Contracts.AppServices
{
    public interface ICategoryAppService
    {
        public List<Category> GetCategories();

    }
}
