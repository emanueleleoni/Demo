using LK2.Models;
using LK2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Repositories
{
    public interface IProductRepository
    {
        ProductLanguage GetProduct(int productID);

        List<ProductViewModel> GetList(int languageID);

        void UpdateProduct(int productID, int categoryID, double price, int selection, int position);

        void DeleteProduct(int categoryProductID, int productID, int position);

        NewProductViewModel AddProduct(int categoryProductID);

        void AddProductToCategory(int categoryProductID, int productID, int position, int selection);
    }
}
