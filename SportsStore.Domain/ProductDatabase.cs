using System.Data.Entity;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain
{
    public class ProductDatabase : DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}
