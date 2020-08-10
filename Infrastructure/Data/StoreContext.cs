using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products {get;set;}
        public DbSet<Unit> Units {get;set;}
        public DbSet<ProductPrice> ProductPrices { get; set; }
    }
}