using System.Linq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    class FakeProductRepository : IProductRepository
    {
        private static IQueryable<Product> fakeProducts = new List<Product>
        {
            new Product { Name = "Baseball", Price = 25 },
            new Product { Name = "Shotgun", Price = 100 },
            new Product { Name = "Marshmallow", Price = 72 }
        }.AsQueryable();

        public IQueryable<Product> Products
        {
            get { return fakeProducts; }
        }
    }
}
