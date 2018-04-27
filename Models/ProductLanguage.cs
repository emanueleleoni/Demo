using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class ProductLanguage
    {
        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int LanguageID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Product Product { get; set; }
        public virtual Language Language { get; set; }
    }
}
