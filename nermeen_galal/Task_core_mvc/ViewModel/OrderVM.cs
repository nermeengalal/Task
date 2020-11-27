using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.ViewModel
{
    public class OrderVM
    {
        public int ID { get; set; }

        public string prodectname { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }
}
