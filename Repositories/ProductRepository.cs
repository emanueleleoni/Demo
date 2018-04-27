using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LK2.Models;

namespace LK2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DatabaseContext db;

        public ProductRepository(DatabaseContext databaseContext){
            db = databaseContext;
        }

        public List<ProductLanguage> GetList()
        {
            return db.ProductLanguages.OrderBy(pl => pl.Product.Position).ToList();
        }

        public ProductLanguage GetProduct(Guid productID)
        {
            return db.ProductLanguages.FirstOrDefault(pl => pl.ProductID.Equals(productID));
        }
    }
}
