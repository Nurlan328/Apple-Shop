using AppleShop.Data.Interface;
using AppleShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleShop.Data.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopCartItems = shopCart.getShopItems();

            bool check = true;
            if (shopCart.listShopCartItems.Count == 0)
            {
                ViewBag.Message = "У вас должны быть товары";
                check = false;
            }
            if (check.Equals(true))
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
