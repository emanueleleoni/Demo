using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LK2.Models;
using Microsoft.EntityFrameworkCore;

namespace LK2.Repositories
{
    public class CategoryProductRepository : ICategoryProductRepository
    {
        private DatabaseContext db;

        public CategoryProductRepository(DatabaseContext databaseContext){
            db = databaseContext;
        }
        public CategoryProductLanguage GetCategory(int categoryProductID)
        {
            return db.CategoryProductLanguages.FirstOrDefault(cpl => cpl.CategoryProductID.Equals(categoryProductID));
        }

        public List<CategoryProductLanguage> GetList(int languageID)
        {
            return db.CategoryProductLanguages.Include(q => q.CategoryProduct).Where(q => q.LanguageID.Equals(languageID)).OrderBy(cpl => cpl.CategoryProduct.Position).ToList();
        }
    }
}
