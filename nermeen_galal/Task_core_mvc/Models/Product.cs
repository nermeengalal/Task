using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Product Name Required")]
    

        public string Name { get; set; }

        [Required(ErrorMessage = "Product Quantity Required")]
       
        public int Quantity { get; set; }

        [Required]
        
       
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Product Description Required")]
        
        public string Description { get; set; }

       
        
        

    }
}
