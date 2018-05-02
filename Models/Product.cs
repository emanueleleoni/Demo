using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public int CategoryProductID { get; set; }
        public virtual CategoryProduct CategoryProduct { get; set; }

        public virtual IEnumerable<ProductLanguage> ProductLanguages { get; set; }
        public virtual IEnumerable<ProductCategoryProductPosition> ProductCategoryProductPositions { get; set; }

        public Product(){
            this.ProductLanguages = new HashSet<ProductLanguage>();
            this.ProductCategoryProductPositions = new HashSet<ProductCategoryProductPosition>();
        }
    }
}
