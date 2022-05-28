using AppleShop.Data.Interface;
using AppleShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using AppleShop.ViewModels;

namespace AppleShop.Data.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _productRep;
        private readonly ShopCart _shopCart;

        public HomeController(IProducts productRepository, ShopCart shopCart)
        {
            _productRep = productRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "All Favourite Products";
            var homeProducts = new HomeViewModel
            {
                favProducts = _productRep.GetFavProducts
            };
            return View(homeProducts);
        }
    }
}
