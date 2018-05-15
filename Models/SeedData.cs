using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LK2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<DatabaseContext>())
            {
                context.Database.EnsureCreated();

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
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        Position = 1
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        Position = 2
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/soda.jpg",
                        Position = 3
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/snacks.jpg",
                        Position = 4
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/snacks.jpg",
                        Position = 5
                    }
                );

                context.CategoryProductLanguages.AddRange(
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 1,
                        LanguageID = 1,
                        Name = "Caffè"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 2,
                        LanguageID = 1,
                        Name = "Bevande calde"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 3,
                        LanguageID = 1,
                        Name = "Bevande fredde"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 4,
                        LanguageID = 1,
                        Name = "Snack dolci"
                    },
                    new CategoryProductLanguage
                    {
                        CategoryProductID = 5,
                        LanguageID = 1,
                        Name = "Snack salati"
                    }
                );

                context.Products.AddRange(
                    // Caffè
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 1,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 2,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 3,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 4,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 5,
                        Price = 1
                    },
                    // Bevande calde
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 6,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 7,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 8,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/Caffe_Bevandecalde.jpg",
                        ProductID = 9,
                        Price = 1
                    },
                    // Bevande fredde
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/acqua_Naturale.jpg",
                        ProductID = 10,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/Acqua_Frizzante.jpg",
                        ProductID = 11,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/coca-cola-50cl-pet.jpg",
                        ProductID = 12,
                        Price = 2
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/fanta-50cl-pet.jpg",
                        ProductID = 13,
                        Price = 2
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/chino-sanpellegrino-50cl-pet.jpg",
                        ProductID = 14,
                        Price = 2
                    },
                   // Snack dolci
                   new Product
                   {
                       CategoryProductID = 4,
                       Image = "/assets/images/kitkat.jpg",
                       ProductID = 15,
                       Price = 1
                   },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/mars.jpg",
                        ProductID = 16,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/MnM.jpg",
                        ProductID = 17,
                        Price = 2
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/twix.jpg",
                        ProductID = 18,
                        Price = 2
                    },
                   // Snack salati
                   new Product
                   {
                       CategoryProductID = 5,
                       Image = "/assets/images/amica-chips-classica-50gr.jpg",
                       ProductID = 19,
                       Price = 1
                   },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/fonzies.jpg",
                        ProductID = 20,
                        Price = 1
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/tuc.jpg",
                        ProductID = 21,
                        Price = 2
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/taralli.jpg",
                        ProductID = 22,
                        Price = 2
                    }
                );

                context.ProductLanguages.AddRange(
                    new ProductLanguage { 
                        ProductID = 1,
                        LanguageID = 1,
                        Name = "Caffè Espresso",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 2,
                        LanguageID = 1,
                        Name = "Caffè Macchiato",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 3,
                        LanguageID = 1,
                        Name = "Caffè Lungo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 4,
                        LanguageID = 1,
                        Name = "Decaffeinato",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 5,
                        LanguageID = 1,
                        Name = "Cappuccino",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 6,
                        LanguageID = 1,
                        Name = "Tè",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 7,
                        LanguageID = 1,
                        Name = "Cioccolata calda",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 8,
                        LanguageID = 1,
                        Name = "Ginseng",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 9,
                        LanguageID = 1,
                        Name = "Latte",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 10,
                        LanguageID = 1,
                        Name = "Acqua Naturale",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                   new ProductLanguage
                   {
                       ProductID = 11,
                       LanguageID = 1,
                       Name = "Acqua Frizzante",
                       Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                   },
                    new ProductLanguage
                    {
                        ProductID = 12,
                        LanguageID = 1,
                        Name = "Coca Cola",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 13,
                        LanguageID = 1,
                        Name = "Fanta",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 14,
                        LanguageID = 1,
                        Name = "Chinotto",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 15,
                        LanguageID = 1,
                        Name = "KitKat",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 16,
                        LanguageID = 1,
                        Name = "Mars",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 17,
                        LanguageID = 1,
                        Name = "M&M",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 18,
                        LanguageID = 1,
                        Name = "Twix",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 19,
                        LanguageID = 1,
                        Name = "Patatine Fritte",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 20,
                        LanguageID = 1,
                        Name = "Fonzies",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 21,
                        LanguageID = 1,
                        Name = "Tuc",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 22,
                        LanguageID = 1,
                        Name = "Taralli",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; ""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    }
                );

                context.ProductCategoryProductPositions.AddRange(
                    // Caffè
                    new ProductCategoryProductPosition
                    { 
                        ProductID = 1,
                        CategoryProductID = 1,
                        Position = 1,
                        Selection = 1,
                        Quantity = 3
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 2,
                        CategoryProductID = 1,
                        Position = 2,
                        Selection = 2,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 3,
                        CategoryProductID = 1,
                        Position = 3,
                        Selection = 3,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 4,
                        CategoryProductID = 1,
                        Position = 4,
                        Selection = 4,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 5,
                        CategoryProductID = 1,
                        Position = 5,
                        Selection = 5,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 1,
                        CategoryProductID = 1,
                        Position = 6,
                        Selection = 23,
                        Quantity = 2
                    },
                    // Bevande calde
                    new ProductCategoryProductPosition
                    {
                        ProductID = 6,
                        CategoryProductID = 2,
                        Position = 1,
                        Selection = 6,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 7,
                        CategoryProductID = 2,
                        Position = 2,
                        Selection = 7,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 8,
                        CategoryProductID = 2,
                        Position = 3,
                        Selection = 8,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 9,
                        CategoryProductID = 2,
                        Position = 4,
                        Selection = 9,
                        Quantity = 0
                    },
                    // Bevande fredde
                    new ProductCategoryProductPosition
                    {
                        ProductID = 10,
                        CategoryProductID = 3,
                        Position = 1,
                        Selection = 10,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 11,
                        CategoryProductID = 3,
                        Position = 2,
                        Selection = 11,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 12,
                        CategoryProductID = 3,
                        Position = 3,
                        Selection = 12,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 13,
                        CategoryProductID = 3,
                        Position = 4,
                        Selection = 13,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 14,
                        CategoryProductID = 3,
                        Position = 5,
                        Selection = 14,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 10,
                        CategoryProductID = 3,
                        Position = 6,
                        Selection = 24,
                        Quantity = 1
                    },
                    // Snack dolci
                    new ProductCategoryProductPosition
                    {
                        ProductID = 15,
                        CategoryProductID = 4,
                        Position = 1,
                        Selection = 15,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 16,
                        CategoryProductID = 4,
                        Position = 2,
                        Selection = 16,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 17,
                        CategoryProductID = 4,
                        Position = 3,
                        Selection = 17,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 18,
                        CategoryProductID = 4,
                        Position = 4,
                        Selection = 18,
                        Quantity = 1
                    },
                    // Snack salati
                    new ProductCategoryProductPosition
                    {
                        ProductID = 19,
                        CategoryProductID = 5,
                        Position = 1,
                        Selection = 19,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 20,
                        CategoryProductID = 5,
                        Position = 2,
                        Selection = 20,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 21,
                        CategoryProductID = 5,
                        Position = 3,
                        Selection = 21,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 22,
                        CategoryProductID = 5,
                        Position = 4,
                        Selection = 22,
                        Quantity = 1
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
