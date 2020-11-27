using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Task_api.Models;

namespace Task_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private ApplicationDbContext context;

        public productController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/product
        public IQueryable<Product> GetProduct()
        {
            return context.Products;
        }
        // GET: api/product/1

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetTodoProduct(int id)
        {
            var todoItem = await context.Products.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

    }
}
