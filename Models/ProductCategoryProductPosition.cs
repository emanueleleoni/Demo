using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class ProductCategoryProductPosition
    {
        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CategoryProductID { get; set; }
        [Key]
        [Column(Order = 3)]
        public int Position { get; set; }

        public virtual Product Product { get; set; }
        public virtual CategoryProduct CategoryProduct { get; set; }
    }
}
