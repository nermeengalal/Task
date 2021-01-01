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
    //[Authorize(Roles = "Admin")]
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
            //var allProduct = _ProductService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult GetallProduct()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            var productData = _ProductService.GetAll().OrderBy(a => a.Name);

            recordsTotal = productData.Count();
            var data = productData.Skip(skip).Take(pageSize).ToList();
           // var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }
        [HttpGet]
        public PartialViewResult add()
        {
            return PartialView("Add");
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
