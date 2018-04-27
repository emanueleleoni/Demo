using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class CategoryProductLanguage
    {
        [Key]
        [Column(Order = 0)]
        public int CategoryProductID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int LanguageID { get; set; }

        public string Name { get; set; }

        public virtual CategoryProduct CategoryProduct { get; set; }
        public virtual Language Language { get; set; }
    }
}
