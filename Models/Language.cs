using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public partial class Language
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual IEnumerable<CategoryProductLanguage> CategoryProductLanguages { get; set; }
        public virtual IEnumerable<ProductLanguage> ProductLanguages { get; set; }

        public Language(){
            this.CategoryProductLanguages = new HashSet<CategoryProductLanguage>();
            this.ProductLanguages = new HashSet<ProductLanguage>();
        }
    }
}
