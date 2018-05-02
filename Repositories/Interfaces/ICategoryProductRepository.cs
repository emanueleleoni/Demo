using LK2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Repositories
{
    public interface ICategoryProductRepository
    {
        CategoryProductLanguage GetCategory(int categoryProductID);

        List<CategoryProductLanguage> GetList(int languageID);
    }
}
