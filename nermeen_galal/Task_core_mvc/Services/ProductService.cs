using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_core_mvc.Data;
using Task_core_mvc.Models;

namespace Task_core_mvc.Services
{
    public class ProductService : ICRUDService<Product>
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Product Model)
        {
            context.Products.Add(Model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = context.Products.Where(p=>p.ID==id).FirstOrDefault();
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetDetails(int id)
        {
            return context.Products.Where(p => p.ID == id).FirstOrDefault();
        }

        public void Update(int id, Product Model)
        {
            var entity = context.Products.Where(p => p.ID == id).FirstOrDefault();

            entity.Name = Model.Name;

            entity.Quantity = Model.Quantity;

            entity.Price = Model.Price;

            entity.Description = Model.Description;

            context.SaveChanges();

        }
    }
}
