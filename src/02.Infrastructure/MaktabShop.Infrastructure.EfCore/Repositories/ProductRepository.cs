using MaktabShop.Domain.Core.Contracts.Repositories;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Infrastructure.EfCore.common;
using Microsoft.EntityFrameworkCore;

namespace MaktabShop.Infrastructure.EfCore.Repositories
{
    public class ProductRepository (AppDbContext dbContext) : IProductRepository
    {
        public void Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Delete(int productId)
        {
            dbContext.Products.Where(x => x.Id == productId).ExecuteDelete();
        }


        public List<Product> GetAll()
        {
            return dbContext.Products.Include(x=>x.Category).AsNoTracking().ToList();
        }

        public Product? GetById(int productId)
        {
            return dbContext.Products.Include(x=>x.Category).AsNoTracking().FirstOrDefault(x => x.Id == productId);
        }

        public void Update(Product product)
        {
            var entity = dbContext.Products.FirstOrDefault(x => x.Id == product.Id);

            if(entity is not null)
            {
                entity.Name = product.Name;
                entity.Description = product.Description;
                entity.Price = product.Price;
                dbContext.SaveChanges();
            }
        }
    }
}
