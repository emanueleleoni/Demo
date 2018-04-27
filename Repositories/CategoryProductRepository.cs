﻿using System;
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
        public CategoryProductLanguage GetCategory(Guid categoryProductID)
        {
            return db.CategoryProductLanguages.FirstOrDefault(cpl => cpl.CategoryProductID.Equals(categoryProductID));
        }

        public List<CategoryProductLanguage> GetList()
        {
            return db.CategoryProductLanguages.Include(q => q.CategoryProduct).OrderBy(cpl => cpl.CategoryProduct.Position).ToList();
        }
    }
}
