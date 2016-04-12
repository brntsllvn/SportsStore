using SportsStore.Domain.Entities;
using System.Linq;

namespace SportsStore.Domain.Abstract
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
