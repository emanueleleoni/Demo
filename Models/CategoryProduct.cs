using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class CategoryProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryProductID { get; set; }

        public string Image { get; set; }

        public int Position { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<CategoryProductLanguage> CategoryProductLanguages { get; set; }
        public virtual IEnumerable<ProductCategoryProductPosition> ProductCategoryProductPositions { get; set; }

        public CategoryProduct() {
            this.Products = new HashSet<Product>();
            this.CategoryProductLanguages = new HashSet<CategoryProductLanguage>();
            this.ProductCategoryProductPositions = new HashSet<ProductCategoryProductPosition>();
        }
    }
}
