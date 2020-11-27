using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Task_core_mvc.Data;
using Task_core_mvc.Models;
using Task_core_mvc.Services;
using Task_core_mvc.ViewModel;

namespace Task_core_mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ICRUDService<Product> _ProductService;
        private readonly IRUDService<Order> _orderService;


        public AdminController(ApplicationDbContext context,ICRUDService<Product> _ProductService,
            IRUDService<Order> _orderService)
        {
            this.context = context;
            this._ProductService = _ProductService;
            this._orderService = _orderService;
        }
        public IActionResult Index()
        {
            var allProduct = _ProductService.GetAll();
            return View(allProduct);
        }

        [HttpGet]
        public IActionResult add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult add(Product product)
        {
            _ProductService.Add(product);
            return RedirectToAction("Index");
        }



        public IActionResult Delete(int  id)
        {
            _ProductService.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var product = _ProductService.GetDetails(id);

            return View(product);
        }

        
        public IActionResult Edit(int id)
        {
            var product = _ProductService.GetDetails(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id , Product product)
        {
            _ProductService.Update(id, product);

            return RedirectToAction("Index");
        }


        public IActionResult GetAllOprder()
        {
            var orders = _orderService.GetAll();
            var list = new List<OrderVM>();
            foreach(var item in orders)
            {
                var name = _ProductService.GetDetails(item.ProductID);
                list.Add(new OrderVM
                {
                    ID = item.ID,
                    prodectname= name.Name,
                    Date= item.Date,
                    Count= item.Count
                }); ;
            }
            return View(list);
        }

        [HttpGet]
        public IActionResult EditOrder(int id)
        {
            var order = _orderService.GetDetails(id);
            var list = _ProductService.GetAll();
            ViewBag.Product = list;
            return View(order);
        }

        [HttpPost]

        public IActionResult EditOrder(int id, Order model)
        {
           _orderService.Update(id, model);
            return RedirectToAction("Index");
        }

        public IActionResult DetailsOrder(int id)
        {
            var order = _orderService.GetDetails(id);
            var product = _ProductService.GetDetails(order.ID);
            OrderVM orderVM = new OrderVM();
            orderVM.prodectname = product.Name;
            orderVM.Date = order.Date;
            orderVM.Count = order.Count;
            return View(orderVM);
        }

        public IActionResult DeleteOrder(int id)
        {
            _orderService.Delete(id);

            return RedirectToAction("Index");
        }

    }
}
