using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LK2.Models
{
    public static class SeedData
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (DatabaseContext context = applicationBuilder.ApplicationServices.GetRequiredService<DatabaseContext>())
            {
                // Look for any movies.
                if (context.CategoryProducts.Any())
                {
                    return;   // DB has been seeded
                }

                context.Languages.AddRange(
                    new Language
                    {
                        LanguageID = 1,
                        Name = "ita",
                        Url = "it-IT"
                    }
                );

                context.CategoryProducts.AddRange(
                    new CategoryProduct
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/water.jpg",
                        Position = 1
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/snacks.jpg",
                        Position = 2
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/soda.jpg",
                        Position = 3
                    }
                );

                context.CategoryProductLanguages.AddRange(
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 1,
                        LanguageID = 1,
                        Name = "Acqua"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 2,
                        LanguageID = 1,
                        Name = "Snacks"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 3,
                        LanguageID = 1,
                        Name = "Bibite"
                    }
                );

                context.Products.AddRange(
                    new Product{
                        CategoryProductID = 1,
                        Image = "/assets/images/water.jpg",
                        ProductID = 1,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/water.jpg",
                        ProductID = 2,
                        Price = 2
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/water.jpg",
                        ProductID = 3,
                        Price = 3
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/snacks.jpg",
                        ProductID = 4,
                        Price = 4
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/snacks.jpg",
                        ProductID = 5,
                        Price = 5
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/snacks.jpg",
                        ProductID = 6,
                        Price = 6
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/soda.jpg",
                        ProductID = 7,
                        Price = 7
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/soda.jpg",
                        ProductID = 8,
                        Price = 8
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/soda.jpg",
                        ProductID = 9,
                        Price = 9
                    }
                );

                context.ProductLanguages.AddRange(
                    new ProductLanguage { 
                        ProductID = 1,
                        LanguageID = 1,
                        Name = "Sant'Anna",
                        Description = "Acqua naturale 50cl"                     
                    },
                    new ProductLanguage
                    {
                        ProductID = 2,
                        LanguageID = 1,
                        Name = "Levissima",
                        Description = "Acqua naturale 50cl"
                    },
                    new ProductLanguage
                    {
                        ProductID = 3,
                        LanguageID = 1,
                        Name = "Rocchetta",
                        Description = "Acqua effervescente naturale 50cl"
                    },
                    new ProductLanguage
                    {
                        ProductID = 4,
                        LanguageID = 1,
                        Name = "Kinder Bueno",
                        Description = "Snack al cioccolato al latte"
                    },
                    new ProductLanguage
                    {
                        ProductID = 5,
                        LanguageID = 1,
                        Name = "Dixie",
                        Description = "Snack salato al formaggio"
                    },
                    new ProductLanguage
                    {
                        ProductID = 6,
                        LanguageID = 1,
                        Name = "Tramezzino",
                        Description = "Panino farcito"
                    },
                    new ProductLanguage
                    {
                        ProductID = 7,
                        LanguageID = 1,
                        Name = "Coca cola",
                        Description = "Bevanda gasata 33cl"
                    },
                    new ProductLanguage
                    {
                        ProductID = 8,
                        LanguageID = 1,
                        Name = "Fanta",
                        Description = "Bibita gassata all'arancia 33cl"
                    },
                    new ProductLanguage
                    {
                        ProductID = 9,
                        LanguageID = 1,
                        Name = "Heineken",
                        Description = "Birra bionda 33cl"
                    }
                );

                context.ProductCategoryProductPositions.AddRange(
                    new ProductCategoryProductPosition{ 
                        ProductID = 1,
                        CategoryProductID = 1,
                        Position = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 2,
                        CategoryProductID = 1,
                        Position = 2
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 3,
                        CategoryProductID = 1,
                        Position = 3
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 4,
                        CategoryProductID = 2,
                        Position = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 5,
                        CategoryProductID = 2,
                        Position = 2
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 6,
                        CategoryProductID = 2,
                        Position = 3
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 7,
                        CategoryProductID = 3,
                        Position = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 8,
                        CategoryProductID = 3,
                        Position = 2
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 9,
                        CategoryProductID = 3,
                        Position = 3
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
