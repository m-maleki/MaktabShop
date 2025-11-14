using MaktabShop.Domain.Core.Entities;
using MaktabShop.Infrastructure.EfCore.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MaktabShop.Infrastructure.EfCore.common
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options )
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfigurations());

            base.OnModelCreating(modelBuilder);
        }


    }
}
