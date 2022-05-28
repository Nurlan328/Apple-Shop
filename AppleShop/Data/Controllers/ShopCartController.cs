using AppleShop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using AppleShop.ViewModels;
using AppleShop.Data.Interface;

namespace AppleShop.Data.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IProducts _productRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IProducts productRepository, ShopCart shopCart)
        {
            _productRep = productRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "All Bucket Items";
            var items = _shopCart.getShopItems();
            _shopCart.listShopCartItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _productRep.GetProducts.FirstOrDefault(x => x.Id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
