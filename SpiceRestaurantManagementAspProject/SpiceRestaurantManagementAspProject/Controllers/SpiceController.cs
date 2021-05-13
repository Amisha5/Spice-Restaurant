using Spice_DataLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Spice_ServiceContract;
using Spice_ServiceLayer;
using Spice_DomainModels.Models;
using Microsoft.AspNet.Identity;
using SpiceRestaurantManagementAspProject.viewModels;

namespace SpiceRestaurantManagementAspProject.Controllers
{
    public class SpiceController : Controller
    {
        ISpiceService iservice;

        SpiceDbContext sd = null;
        public SpiceController()
        {
            iservice = new SpiceService();
            sd = new SpiceDbContext();
        }
        
        // GET: Spice
        public ActionResult MenuDeatils()
        {
            //var menu = spiceService.GetCategories();
            ViewBag.UsrId = User.Identity.GetUserId();
            var menu = iservice.GetDetails();
            return View(menu);
        }
        [Authorize]
        public ActionResult MenuById(int id)
        {
            ViewBag.UsrId = User.Identity.GetUserId();
            if (User.Identity.IsAuthenticated)
            {
                var details = iservice.GetMenuDetailsById(id);
             
                return View(details);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            
        }
        public ActionResult Appetizer()
        {
            var Appdetail = iservice.GetAppetizer();
            return View(Appdetail);
        }
        public ActionResult Desserts()
        {
            var desserts = iservice.GetDesserts();
                return View(desserts);
        }
        public ActionResult Beverage()
        {
            var beverages = iservice.GetBaverage();
            return View(beverages);
        }
        public ActionResult MainCourse()
        {
            var Appdetail = iservice.GetMainCourse();
            return View(Appdetail);
        }

        public ActionResult AddToCartItem(int MenuId, ShoppingCart cartdet)
        {
            ViewBag.UsrId = User.Identity.GetUserId();
            string appId = ViewBag.UsrId;
            iservice.AddToCart(cartdet, MenuId, appId);
            return RedirectToAction("GetShoppingCart", "Spice");
        }

        [Authorize]
        public ActionResult GetShoppingCart()
        {
            ViewBag.Message = "Item in your Cart";
            ViewBag.UsrId = User.Identity.GetUserId();
            string appId = ViewBag.UsrId;
            var cartItems = iservice.GetShoppingCartdata(appId);
            return View(cartItems);
        }
        public ActionResult DeleteCartItem(int id)
        {
            iservice.DeleteItemFromCart(id);
            return RedirectToAction("GetShoppingCart");
        }

        public ActionResult AddSign(int id)
        {
            iservice.PlusCountItem(id);
            return RedirectToAction("GetShoppingCart");
        }
        public ActionResult MinusSign(int id)
        {
            iservice.MinusCountItem(id);
            return RedirectToAction("GetShoppingCart");
        }


        public ActionResult Summary()
        {
           
            ViewBag.UsrId = User.Identity.GetUserId();
            string appId = ViewBag.UsrId;
            var res=iservice.GetOrderDetails(appId);
            return View(res);
        }
        
        public ActionResult InsertRecord()
        {
            ViewBag.userName = User.Identity.GetUserName();
            ViewBag.Email = User.Identity.Name;
            return View();
        }
        [HttpPost]
        public ActionResult InsertRecord(OrderSummary order)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("InsertRecord");
            }
            else
            {
                iservice.InsertOrderDetails(order);
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult CartRemove()
        {
            ViewBag.UsrId = User.Identity.GetUserId();
            string appId = ViewBag.UsrId;
            iservice.CartRemoveData(appId);
            return RedirectToAction("MenuDeatils");
        }
    }
}