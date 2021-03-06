﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LK2.Models;
using LK2.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LK2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DatabaseContext db;

        public ProductRepository(DatabaseContext databaseContext){
            db = databaseContext;
        }

        public List<ProductViewModel> GetList(int languageID)
        {
            SqlCommand cmd = new SqlCommand("select * from ProductCategoryProductPositions pcp inner join Products p on pcp.productid = p.productid inner join ProductLanguages pl on p.productid = pl.productid where pl.languageid = 1 order by pcp.categoryproductid, pcp.position");

            List<ProductViewModel> collection = (from x in db.ProductCategoryProductPositions
                                         join y in db.Products on x.ProductID equals y.ProductID
                                         join z in db.ProductLanguages on y.ProductID equals z.ProductID
                                         select new ProductViewModel
                                         {
                                            categoryID = x.CategoryProductID,
                                            description = z.Description,
                                            image = y.Image,
                                            name = z.Name,
                                            position = x.Position,
                                            price = y.Price,
                                            productID = y.ProductID,
                                            selections = new List<Selection> { new Selection { selection = x.Selection, quantity = x.Quantity } }
                                         }).ToList();

            var products = new List<ProductViewModel>();
            foreach(var product in collection) {
                // Se il prodotto non è presente nella lista, lo inserisce
                if (!products.Any(p => p.productID.Equals(product.productID))) {
                    products.Add(product);
                }
                // Altrimenti lo recupera e aggiunge una nuova lista Selection - Quantità
                else {
                    var multipleProduct = products.FirstOrDefault(p => p.productID.Equals(product.productID));
                    foreach(var selection in product.selections)
                        multipleProduct.selections.Add(selection);
                }
            }

            return products;
        }

        public List<ProductViewModel> GetAdminList(int languageID)
        {
            SqlCommand cmd = new SqlCommand("select * from ProductCategoryProductPositions pcp inner join Products p on pcp.productid = p.productid inner join ProductLanguages pl on p.productid = pl.productid where pl.languageid = 1 order by pcp.categoryproductid, pcp.position");

            List<ProductViewModel> collection = (from x in db.ProductCategoryProductPositions
                                                 join y in db.Products on x.ProductID equals y.ProductID
                                                 join z in db.ProductLanguages on y.ProductID equals z.ProductID
                                                 select new ProductViewModel
                                                 {
                                                     categoryID = x.CategoryProductID,
                                                     description = z.Description,
                                                     image = y.Image,
                                                     name = z.Name,
                                                     position = x.Position,
                                                     price = y.Price,
                                                     productID = y.ProductID,
                                                     selections = new List<Selection> { new Selection { selection = x.Selection, quantity = x.Quantity } }
                                                 }).ToList();

            return collection;
        }

        public ProductLanguage GetProduct(int productID)
        {
            return db.ProductLanguages.FirstOrDefault(pl => pl.ProductID.Equals(productID));
        }

        public void UpdateProduct(int productID, int categoryProductID, double price, int selection, int quantity, int position){
            var product = db.Products.FirstOrDefault(p => p.ProductID.Equals(productID));
            product.Price = price;
            var productCategory = db.ProductCategoryProductPositions.FirstOrDefault(pcp => pcp.ProductID.Equals(productID) &&
                                                                                           pcp.CategoryProductID.Equals(pcp.CategoryProductID) &&
                                                                                           pcp.Position.Equals(position));
            productCategory.Selection = selection;
            productCategory.Quantity = quantity;

            db.SaveChanges();
        }

        public void DeleteProduct(int categoryProductID, int productID, int position){
            var product = db.ProductCategoryProductPositions.FirstOrDefault(q => q.ProductID.Equals(productID) &&
                                                                                 q.CategoryProductID.Equals(categoryProductID) &&
                                                                                 q.Position.Equals(position));

            db.ProductCategoryProductPositions.Remove(product);
            db.SaveChanges();
        }

        public NewProductViewModel AddProduct(int categoryProductID){
            var position = GetLastPosition(categoryProductID) + 1;

            return new NewProductViewModel
            {
                categoryID = categoryProductID,
                productsAvailable = this.GetList(1).Where(q => q.categoryID.Equals(categoryProductID)).ToList(),
                position = position
            };
        }

        private int GetLastPosition(int categoryProductID){
            var products = this.GetList(1);
            return products.Where(p => p.categoryID.Equals(categoryProductID)).OrderByDescending(p => p.position).FirstOrDefault().position;
        }

        public void AddProductToCategory(int categoryProductID, int productID, int position, int selection, int quantity){
            db.ProductCategoryProductPositions.Add(new ProductCategoryProductPosition { 
                CategoryProductID = categoryProductID,
                ProductID = productID,
                Position = position,
                Selection = selection,
                Quantity = quantity
            });

            db.SaveChanges();
        }

        public void UpdateQuantity(int selection){
            var product = db.ProductCategoryProductPositions.FirstOrDefault(q => q.Selection.Equals(selection));
            product.Quantity--;

            db.SaveChanges();
        }
    }
}
