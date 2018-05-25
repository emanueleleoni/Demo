using Newtonsoft.Json;
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
        public List<Selection> selections = new List<Selection>();
        public int quantity {
            get {
                return selections.Sum(s => s.quantity);
            }
        }
        public string JsonSelection
        {
            get
            {
                return JsonConvert.SerializeObject(this.selections);
            }
        }
    }

    public class Selection {
        public string selection { get; set; }
        public int quantity { get; set; }
    }
}
