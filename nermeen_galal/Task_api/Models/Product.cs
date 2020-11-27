using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_api.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }
    }
}
