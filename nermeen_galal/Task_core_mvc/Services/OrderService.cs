using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_core_mvc.Data;
using Task_core_mvc.Models;

namespace Task_core_mvc.Services
{
    public class OrderService: IRUDService<Order>
    {
        private readonly ApplicationDbContext context;

        public OrderService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var entity = context.Orders.Where(p => p.ID == id).FirstOrDefault();
            context.Orders.Remove(entity);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order GetDetails(int id)
        {
            return context.Orders.Where(p => p.ID == id).FirstOrDefault();
        }

        public void Update(int id, Order Model)
        {
            var entity = context.Orders.Where(p => p.ID == id).FirstOrDefault();

            entity.ProductID = Model.ProductID;

            entity.Date = Model.Date;

            entity.Count = Model.ProductID;

           

            context.SaveChanges();

        }
    }
}
