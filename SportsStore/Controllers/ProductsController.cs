using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController()
        {
            _productsRepository = new FakeProductsRepository();
        }

        public ViewResult List()
        {
            return View(_productsRepository.Products.ToList());
        }
    }
}