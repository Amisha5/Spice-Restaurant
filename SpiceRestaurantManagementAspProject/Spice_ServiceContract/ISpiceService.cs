using Spice_DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_ServiceContract
{

    public interface ISpiceService
    {
        List<MenuItem> GetDetails();
        MenuItem GetMenuDetailsById(int menuId);

        List<MenuItem> GetAppetizer();
        List<MenuItem> GetDesserts();
        List<MenuItem> GetBaverage();
        List<MenuItem> GetMainCourse();

        void AddToCart(ShoppingCart cart, int MenuId, string applicationId);

        IEnumerable<ShoppingCart> GetShoppingCartdata(string appId);
        //ShoppingCart GetShoppingCart(int ShopingId);

        void DeleteItemFromCart(int shopId);

        void PlusCountItem(int countId);

        void MinusCountItem(int countId);

        //void OrderSummary(OrderSummary order,int MenuId,string appId);
        IEnumerable<ShoppingCart> GetOrderDetails(string appliId);

        void InsertOrderDetails(OrderSummary orderSummary);

        void CartRemoveData(string UserName);
    }
}
