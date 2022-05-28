using AppleShop.Data.Interface;
using AppleShop.Data.Models;

namespace AppleShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;


        public OrdersRepository (AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.listShopCartItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductId = item.Product.Id,
                    orderID = order.Id,
                    price = item.Product.Price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
