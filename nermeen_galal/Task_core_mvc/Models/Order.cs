using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        
        public DateTime Date { get; set; }
        public int Count { get; set; }
       

    }
}
