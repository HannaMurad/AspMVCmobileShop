using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCMobileSlut.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderDetails = new List<OrderDetails>();

            var ShoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach(var shoppingCartItem in ShoppingCartItems)
            {
                var orderDetail = new OrderDetails
                {
                    Amount = shoppingCartItem.Amount,
                    MoblieId = shoppingCartItem.Mobile.MobileId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Mobile.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
