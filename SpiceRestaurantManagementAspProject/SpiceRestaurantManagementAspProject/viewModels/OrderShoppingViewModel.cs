using Spice_DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpiceRestaurantManagementAspProject.viewModels
{
    public class OrderShoppingViewModel
    {
        public List<ShoppingCart> shoppingCarts { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
        public OrderSummary orderSummary { get; set; }
    }
}