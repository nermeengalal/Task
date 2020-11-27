using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_api.Models
{
    public class Order
    {
        public int ID { get; set; }
       
        public int ProductID { get; set; }

       

        public DateTime Date { get; set; }
        public int Count { get; set; }
    }
}
