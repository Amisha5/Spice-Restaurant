using Spice_DataLayer;
using Spice_DomainModels.Models;
using Spice_ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Spice_ServiceLayer
{
    public class SpiceService : ISpiceService
    {
        SpiceDbContext db;
        public SpiceService()
        {
            this.db = new SpiceDbContext(); 
        }

        public List<MenuItem> GetAppetizer()
        {
            var appRes = db.MenuItems.Include(e => e.Category).Include(m => m.SubCategory).ToList();
            return appRes;
        }

        public List<MenuItem> GetBaverage()
        {
            var appBev = db.MenuItems.Include(e => e.Category).Include(m => m.SubCategory).ToList();
            return appBev;
        }

        public List<MenuItem> GetDesserts()
        {
            var appDes = db.MenuItems.Include(e => e.Category).Include(m => m.SubCategory).ToList();
            return appDes;
        }

        public List<MenuItem> GetDetails()
        {
            var allMenuCat = db.MenuItems.Include(e => e.Category).Include(e => e.SubCategory).ToList();
            return allMenuCat;
          
        }

        public List<MenuItem> GetMainCourse()
        {
            var appMain = db.MenuItems.Include(e => e.Category).Include(m => m.SubCategory).ToList();
            return appMain;
        }

        public MenuItem GetMenuDetailsById(int menuId)
        {
            var oneMenu = db.MenuItems.Include(e => e.Category).Where(e => e.Id == menuId).FirstOrDefault();
            //var sub = db.MenuItems.Include(e => e.SubCategory).Where(e => e.Id == menuId).FirstOrDefault();
            return oneMenu;
        }

        public void AddToCart(ShoppingCart cart, int id, string appId)
        {
            var cItem = db.ShoppingCarts.ToList().Where(e => e.ApplicationUserId == appId && e.MenuId == id).FirstOrDefault();
            if (cItem == null)
            {
               db.ShoppingCarts.Add(cart);
               db.SaveChanges();
            }
            else
            {
                cItem.count = cItem.count + 1;
                db.SaveChanges();
            }
            
        }

        public IEnumerable<ShoppingCart> GetShoppingCartdata(string appId)
        {
            var cartItem = db.ShoppingCarts.Where(e => e.ApplicationUserId == appId).ToList();
            return cartItem;
        }

        public void DeleteItemFromCart(int shopId)
        {
            var del = db.ShoppingCarts.Where(d => d.MenuId == shopId).FirstOrDefault();
            db.ShoppingCarts.Remove(del);
            db.SaveChanges();
        }

        public void PlusCountItem(int countId)
        {
            var cid = db.ShoppingCarts.FirstOrDefault(c => c.MenuId == countId);
            cid.count += 1;
            db.SaveChanges();
        }

        public void MinusCountItem(int countId)
        {
            var cid = db.ShoppingCarts.FirstOrDefault(c => c.MenuId == countId);
            
            if(cid.count==1)
            {
                db.ShoppingCarts.Remove(cid);
                db.SaveChanges();
            }
           else
            {
                cid.count -= 1;
                db.SaveChanges();
            }
        }

        //public void OrderSummary(OrderSummary order,int id,string appId)
        //{

        //    var orderSum = db.OrderSummaries.ToList().Where(e => e.ApplicationUserId == appId && e.MenuId == id).FirstOrDefault();
        //    if (orderSum == null)
        //    {
        //        db.OrderSummaries.Add(order);
        //        db.SaveChanges();
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Item In Your Cart");
        //    }
        //}

        public IEnumerable<ShoppingCart> GetOrderDetails(string appliId)
        {
            var summ = db.ShoppingCarts.Where(e => e.ApplicationUserId == appliId).ToList();
            return summ;
        }

        public void InsertOrderDetails(OrderSummary orderSummary)
        {
            db.OrderSummaries.Add(orderSummary);
            db.SaveChanges();
        }

        public void CartRemoveData(string UserName)
        {
            var cartData = db.ShoppingCarts.Where(e => e.ApplicationUserId == UserName);
            db.ShoppingCarts.RemoveRange(cartData);
            db.SaveChanges();
        }

        //public ShoppingCart GetShoppingCart(int ShopId)
        //{
        //    var shopingItem = db.shoppingCarts.Include(e => e.MenuItem).Where(c => c.CartId == ShopId).FirstOrDefault();
        //    return shopingItem;
        //}



    }
}
