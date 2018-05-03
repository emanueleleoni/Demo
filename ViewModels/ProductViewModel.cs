using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.ViewModels
{
    public class ProductViewModel
    {
        public int productID { get; set; }
        public int categoryID { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int position { get; set; }
        public double price { get; set; }
        public int selection { get; set; }
    }
}
