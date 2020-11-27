using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_core_mvc.Data;
using Task_core_mvc.Helpers;
using Task_core_mvc.Models;
using Task_core_mvc.Services;

namespace Task_core_mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly ICRUDService<Product> _ProductService;
        private readonly IRUDService<Order> _orderService;

        private readonly ApplicationDbContext context;
        public UserController(ICRUDService<Product> _ProductService,
            IRUDService<Order> _orderService, ApplicationDbContext context)
        {
            this._ProductService = _ProductService;
            this._orderService = _orderService;

            this.context = context;
        }
        public IActionResult Index()
        {
            var allProduct = _ProductService.GetAll();
            return View(allProduct);
        }

        public IActionResult getCart(int id)
        {
            var cart = SessionHelper.GetObjectAsJson<List<item>>(HttpContext.Session,"cart");

            if (cart == null)
            {
                cart = new List<item>();
                cart.Add(new item {
                    Product = _ProductService.GetDetails(id),
                    Quantity=1

                });

                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
                {
                cart.Add(new item
                {
                    Product = _ProductService.GetDetails(id),
                    Quantity = 1

                });

                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Cart");
        }


        public IActionResult Cart()
        {

            var cart = SessionHelper.GetObjectAsJson<List<item>>(HttpContext.Session, "cart");
            return View(cart);
        }
        public IActionResult Order()
        {
            var cart = SessionHelper.GetObjectAsJson<List<item>>(HttpContext.Session, "cart");

            foreach (var item in cart)
            {
                Order o = new Order();
                o.ProductID = item.Product.ID;
                o.Date = DateTime.Now;
                o.Count = item.Quantity;
                
                context.Orders.Add(o);

                context.SaveChanges();


            }
                return RedirectToAction("Index");

        }
    }
}
