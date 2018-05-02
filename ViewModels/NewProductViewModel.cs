using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.ViewModels
{
    public class NewProductViewModel
    {
        public int position { get; set; }
        public List<ProductViewModel> productsAvailable { get; set; }
        public int categoryID { get; set; }
    }
}
