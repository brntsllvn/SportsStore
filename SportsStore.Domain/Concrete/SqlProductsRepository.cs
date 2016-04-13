using System.Linq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    class SqlProductsRepository : IProductsRepository
    {
        private ProductDatabase _db; 

        public SqlProductsRepository()
        {
            
        }

        public IQueryable<Product> Products { get; }
    }
}
