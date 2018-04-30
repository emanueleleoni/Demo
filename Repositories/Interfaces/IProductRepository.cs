using LK2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Repositories
{
    public interface IProductRepository
    {
        ProductLanguage GetProduct(Guid productID);

        List<ProductLanguage> GetList(int languageID);
    }
}
