﻿using Microsoft.AspNetCore.Builder;
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

                #region languages
                context.Languages.AddRange(
                    new Language
                    {
                        LanguageID = 1,
                        Name = "ita",
                        Url = "it-IT"
                    }
                );
                #endregion

                #region categoryProduct
                context.CategoryProducts.AddRange(
                    new CategoryProduct
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/bg-cat1.jpg",
                        Position = 1
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/bg-cat2.jpg",
                        Position = 2
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/bg-cat3.jpg",
                        Position = 3
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/bg-cat4.jpg",
                        Position = 4
                    },
                    new CategoryProduct
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/bg-cat5.jpg",
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
                #endregion

                #region products
                context.Products.AddRange(
                    // Caffè
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe.jpg",
                        ProductID = 1,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_plus.jpg",
                        ProductID = 2,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_lungo.jpg",
                        ProductID = 3,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_macchiato.jpg",
                        ProductID = 4,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_orzo.jpg",
                        ProductID = 5,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_orzo_bio.jpg",
                        ProductID = 6,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_orzo_macchiato.jpg",
                        ProductID = 7,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_ginseng.jpg",
                        ProductID = 8,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/caffe_nocciola.jpg",
                        ProductID = 9,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/cappuccino.jpg",
                        ProductID = 10,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/cappuccino_orzo.jpg",
                        ProductID = 11,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 1,
                        Image = "/assets/images/cappucioc.jpg",
                        ProductID = 12,
                        Price = 0
                    },
                    // Bevande calde
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/cioccolato.jpg",
                        ProductID = 13,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/latte.jpg",
                        ProductID = 14,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/latte_vaniglia.jpg",
                        ProductID = 15,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/the.jpg",
                        ProductID = 16,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/the_limone.jpg",
                        ProductID = 17,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/the_verde.jpg",
                        ProductID = 18,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/camomilla.jpg",
                        ProductID = 19,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 2,
                        Image = "/assets/images/infuso.jpg",
                        ProductID = 20,
                        Price = 0
                    },
                    // Bevande fredde
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/acqua_natia_frizzante.png",
                        ProductID = 21,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/acqua_natia_naturale.png",
                        ProductID = 22,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/acqua_sanbenedetto_frizzante.png",
                        ProductID = 23,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/acqua_sanbenedetto_naturale.png",
                        ProductID = 24,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/aranciata_fanta.png",
                        ProductID = 25,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/coca_cola.png",
                        ProductID = 26,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/pepsi.png",
                        ProductID = 27,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/sprite.png",
                        ProductID = 28,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/thè_limone_sanbenedetto.png",
                        ProductID = 29,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/thè_pesca_sanbenedetto.png",
                        ProductID = 30,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/yogurt_ananas_yovì.png",
                        ProductID = 31,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/yogurt_arancia_carota_limone_yovì.png",
                        ProductID = 32,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/yogurt_banana_yovì.png",
                        ProductID = 33,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/yogurt_bianco_yovì.png",
                        ProductID = 34,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 3,
                        Image = "/assets/images/yogurt_frutta_yovì.png",
                        ProductID = 35,
                        Price = 0
                    },
                   // Snack dolci
                   new Product
                   {
                       CategoryProductID = 4,
                       Image = "/assets/images/bauli_5cereali_pesca_melograno.png",
                       ProductID = 36,
                       Price = 0
                   },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/bauli_capriccio_di_crema.png",
                        ProductID = 37,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/bounty.png",
                        ProductID = 38,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/bueno.png",
                        ProductID = 39,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/buondì_motta_albicocca.png",
                        ProductID = 40,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/crostatina_frutti_di_bosco_germinal.png",
                        ProductID = 41,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/crostatina_mirtillo_germinal.png",
                        ProductID = 42,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/delice.png",
                        ProductID = 43,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/fiesta.png",
                        ProductID = 44,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/loacker_latte.png",
                        ProductID = 45,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/loacker_napolitaner.png",
                        ProductID = 46,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/loacker_vaniglia.png",
                        ProductID = 47,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 4,
                        Image = "/assets/images/twix.png",
                        ProductID = 48,
                        Price = 0
                    },
                   // Snack salati
                   new Product
                   {
                       CategoryProductID = 5,
                       Image = "/assets/images/crackers_doriano.png",
                       ProductID = 49,
                       Price = 0
                   },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/focaccia_mortadella_IGP.png",
                        ProductID = 50,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/panino_crudo_formaggio.png",
                        ProductID = 51,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/panino_salame_piccante_provola_affumicata.png",
                        ProductID = 52,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/patatine_sancarlo_classica.png",
                        ProductID = 53,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/patatine_sancarlo_light.png",
                        ProductID = 54,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/patatine_sancarlo_piùgusto.png",
                        ProductID = 55,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/picadora_sancarlo.png",
                        ProductID = 56,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/pistacchi_salati_cameo.png",
                        ProductID = 57,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/rodeo_sancarlo.png",
                        ProductID = 58,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/semi_girasole_mogyi.png",
                        ProductID = 59,
                        Price = 0
                    },
                    new Product
                    {
                        CategoryProductID = 5,
                        Image = "/assets/images/tuc.png",
                        ProductID = 60,
                        Price = 0
                    }
                );

                context.ProductLanguages.AddRange(
                    new ProductLanguage { 
                        ProductID = 1,
                        LanguageID = 1,
                        Name = "Caffè Espresso",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">2kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,12g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,18g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 2,
                        LanguageID = 1,
                        Name = "Caffè Espresso Plus",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">2kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,12g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,18g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 3,
                        LanguageID = 1,
                        Name = "Caffè Lungo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">2kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,12g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,18g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 4,
                        LanguageID = 1,
                        Name = "Caffè Macchiato",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali per 1 tazzina di caffè espresso (60 ml)</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie</td><td style=""text - align:center"">10kcal</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,67g</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,53g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,56g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 5,
                        LanguageID = 1,
                        Name = "Caffè d'orzo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">6kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,1g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">1,3g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,04g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 6,
                        LanguageID = 1,
                        Name = "Caffè d'orzo BIO",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">6kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,1g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">1,3g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,04g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 7,
                        LanguageID = 1,
                        Name = "Caffè d'orzo macchiato",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale per 100 g</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">67,33kcal</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 8,
                        LanguageID = 1,
                        Name = "Caffè Ginseng",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">83kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">4,41g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">6,47g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">4,42g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 9,
                        LanguageID = 1,
                        Name = "Caffè Nocciola",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">28kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,9g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">5,2g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,3g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 10,
                        LanguageID = 1,
                        Name = "Cappuccino",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">74kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">4,08g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">5,81g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">3,98g</td></tr></tbody></table>"
                    },
                   new ProductLanguage
                   {
                       ProductID = 11,
                       LanguageID = 1,
                       Name = "Cappuccino d'orzo",
                       Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">78kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">1,8g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">12,1g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">1,4g</td></tr></tbody></table>"
                   },
                    new ProductLanguage
                    {
                        ProductID = 12,
                        LanguageID = 1,
                        Name = "Capciock",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">440kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">8,4g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">73g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">12g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 13,
                        LanguageID = 1,
                        Name = "Cioccolata",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">472kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">12,1g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">36,2g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">47,7g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 14,
                        LanguageID = 1,
                        Name = "Latte",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">42kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">3,4g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">5g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">1g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 15,
                        LanguageID = 1,
                        Name = "Latte Vaniglia",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">54kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">3.27g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">6.28g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">1.75g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 16,
                        LanguageID = 1,
                        Name = "Thè",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">1kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,3g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 17,
                        LanguageID = 1,
                        Name = "Thè al Limone",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">40kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0,09g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">9,5g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0,09g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 18,
                        LanguageID = 1,
                        Name = "Thè Verde",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">2kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,47g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 19,
                        LanguageID = 1,
                        Name = "Camomilla",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">1kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,2g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 20,
                        LanguageID = 1,
                        Name = "Infuso",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">1kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,2g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 21,
                        LanguageID = 1,
                        Name = "Acqua Natia Frizzante",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Etichetta nutrizionale</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Valore energetico (calorie)</td><td style=""text - align:center"">1kcal</td></tr><tr><td style=""text - align:left"">Proteine</td><td style=""text - align:center"">0g</td></tr><tr><td style=""text - align:left"">Carboidrati</td><td style=""text - align:center"">0,2g</td></tr><tr><td style=""text - align:left"">Grassi</td><td style=""text - align:center"">0g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 22,
                        LanguageID = 1,
                        Name = "Acqua Natia Naturale",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 23,
                        LanguageID = 1,
                        Name = "Acqua San Benedetto Frizzante",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 24,
                        LanguageID = 1,
                        Name = "Acqua San Benedetto Naturale",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 25,
                        LanguageID = 1,
                        Name = "Fanta",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 26,
                        LanguageID = 1,
                        Name = "Coca Cola",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 27,
                        LanguageID = 1,
                        Name = "Pepsi",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 28,
                        LanguageID = 1,
                        Name = "Sprite",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 29,
                        LanguageID = 1,
                        Name = "Thè San Benedetto Limone",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 30,
                        LanguageID = 1,
                        Name = "Thè San Benedetto Pesca",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 31,
                        LanguageID = 1,
                        Name = "Yogurt Ananas Yovì",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 32,
                        LanguageID = 1,
                        Name = "Yogurt Ace Yovì",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 33,
                        LanguageID = 1,
                        Name = "Yogurt Banana Yovì",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 34,
                        LanguageID = 1,
                        Name = "Yogurt Bianco Yovì",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 35,
                        LanguageID = 1,
                        Name = "Yogurt Frutta Yovì",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 36,
                        LanguageID = 1,
                        Name = "Bauli 5 Cereali Pesca Melograno",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 37,
                        LanguageID = 1,
                        Name = "Bauli Capriccio Crema",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 38,
                        LanguageID = 1,
                        Name = "Bounty",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 39,
                        LanguageID = 1,
                        Name = "Bueno",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 40,
                        LanguageID = 1,
                        Name = "Buondì Motta Albicocca",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 41,
                        LanguageID = 1,
                        Name = "Crostatina Frutti Bosco Germinal",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 42,
                        LanguageID = 1,
                        Name = "Crostatina Mirtillo Germinal",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 43,
                        LanguageID = 1,
                        Name = "Kinder Delice",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 44,
                        LanguageID = 1,
                        Name = "Kinder Fiesta",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 45,
                        LanguageID = 1,
                        Name = "Loacker Latte",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 46,
                        LanguageID = 1,
                        Name = "Loacker Napolitaner",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 47,
                        LanguageID = 1,
                        Name = "Loacker Vaniglia",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 48,
                        LanguageID = 1,
                        Name = "Twix",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 49,
                        LanguageID = 1,
                        Name = "Crackers Doriano",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 50,
                        LanguageID = 1,
                        Name = "Focaccia Mortadella",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 51,
                        LanguageID = 1,
                        Name = "Panino Crudo Formaggio",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 52,
                        LanguageID = 1,
                        Name = "Panino Salame Pic. Provola Pic.",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 53,
                        LanguageID = 1,
                        Name = "Patatine San Carlo Classica",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 54,
                        LanguageID = 1,
                        Name = "Patatine San Carlo Light",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 55,
                        LanguageID = 1,
                        Name = "Patatine San Carlo Più Gusto",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 56,
                        LanguageID = 1,
                        Name = "Picadora San Carlo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 57,
                        LanguageID = 1,
                        Name = "Pistacchi Salati Cameo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 58,
                        LanguageID = 1,
                        Name = "Rodeo San Carlo",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 59,
                        LanguageID = 1,
                        Name = "Semi Girasole Mmgyi",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    },
                    new ProductLanguage
                    {
                        ProductID = 60,
                        LanguageID = 1,
                        Name = "Tuc",
                        Description = @"<table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:auto; margin:0 auto;""><thead><tr><th colspan=""2""><strong>Informazioni Nutrizionali</strong></th></tr></thead><tbody><tr><td style=""text - align:left"">Calorie:</td><td style=""text - align:center"">500Kcal</td></tr><tr><td style=""text - align:left"">Carboidrati:</td><td style=""text - align:center"">10g</td></tr><tr><td style=""text - align:left"">Proteine:</td><td style=""text - align:center"">6g</td></tr><tr><td style=""text - align:left"">Grassi:</td><td style=""text - align:center"">2g</td></tr></tbody></table>"
                    }
                );
                #endregion

                #region positions
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
                        ProductID = 6,
                        CategoryProductID = 1,
                        Position = 6,
                        Selection = 6,
                        Quantity = 2
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 7,
                        CategoryProductID = 1,
                        Position = 7,
                        Selection = 7,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 8,
                        CategoryProductID = 1,
                        Position = 8,
                        Selection = 8,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 9,
                        CategoryProductID = 1,
                        Position = 9,
                        Selection = 9,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 10,
                        CategoryProductID = 1,
                        Position = 10,
                        Selection = 10,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 11,
                        CategoryProductID = 1,
                        Position = 11,
                        Selection = 11,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 12,
                        CategoryProductID = 1,
                        Position = 12,
                        Selection = 12,
                        Quantity = 0
                    },
                    // Bevande calde
                    new ProductCategoryProductPosition
                    {
                        ProductID = 13,
                        CategoryProductID = 2,
                        Position = 1,
                        Selection = 13,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 13,
                        CategoryProductID = 2,
                        Position = 2,
                        Selection = 13,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 14,
                        CategoryProductID = 2,
                        Position = 3,
                        Selection = 14,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 15,
                        CategoryProductID = 2,
                        Position = 4,
                        Selection = 15,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 16,
                        CategoryProductID = 2,
                        Position = 5,
                        Selection = 16,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 17,
                        CategoryProductID = 2,
                        Position = 6,
                        Selection = 17,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 18,
                        CategoryProductID = 2,
                        Position = 7,
                        Selection = 18,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 19,
                        CategoryProductID = 2,
                        Position = 8,
                        Selection = 19,
                        Quantity = 0
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 20,
                        CategoryProductID = 2,
                        Position = 9,
                        Selection = 20,
                        Quantity = 0
                    },
                    // Bevande fredde
                    new ProductCategoryProductPosition
                    {
                        ProductID = 21,
                        CategoryProductID = 3,
                        Position = 1,
                        Selection = 21,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 22,
                        CategoryProductID = 3,
                        Position = 2,
                        Selection = 22,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 23,
                        CategoryProductID = 3,
                        Position = 3,
                        Selection = 23,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 24,
                        CategoryProductID = 3,
                        Position = 4,
                        Selection = 24,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 25,
                        CategoryProductID = 3,
                        Position = 5,
                        Selection = 25,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 26,
                        CategoryProductID = 3,
                        Position = 6,
                        Selection = 26,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 27,
                        CategoryProductID = 3,
                        Position = 7,
                        Selection = 27,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 28,
                        CategoryProductID = 3,
                        Position = 8,
                        Selection = 28,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 29,
                        CategoryProductID = 3,
                        Position = 9,
                        Selection = 29,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 30,
                        CategoryProductID = 3,
                        Position = 10,
                        Selection = 30,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 31,
                        CategoryProductID = 3,
                        Position = 11,
                        Selection = 31,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 32,
                        CategoryProductID = 3,
                        Position = 12,
                        Selection = 32,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 33,
                        CategoryProductID = 3,
                        Position = 13,
                        Selection = 33,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 34,
                        CategoryProductID = 3,
                        Position = 14,
                        Selection = 34,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 35,
                        CategoryProductID = 3,
                        Position = 15,
                        Selection = 35,
                        Quantity = 1
                    },
                    // Snack dolci
                    new ProductCategoryProductPosition
                    {
                        ProductID = 36,
                        CategoryProductID = 4,
                        Position = 1,
                        Selection = 36,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 37,
                        CategoryProductID = 4,
                        Position = 2,
                        Selection = 37,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 38,
                        CategoryProductID = 4,
                        Position = 3,
                        Selection = 38,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 39,
                        CategoryProductID = 4,
                        Position = 4,
                        Selection = 39,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 40,
                        CategoryProductID = 4,
                        Position = 5,
                        Selection = 40,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 41,
                        CategoryProductID = 4,
                        Position = 5,
                        Selection = 41,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 42,
                        CategoryProductID = 4,
                        Position = 5,
                        Selection = 42,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 43,
                        CategoryProductID = 4,
                        Position = 6,
                        Selection = 43,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 44,
                        CategoryProductID = 4,
                        Position = 7,
                        Selection = 44,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 45,
                        CategoryProductID = 4,
                        Position = 8,
                        Selection = 45,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 46,
                        CategoryProductID = 4,
                        Position = 9,
                        Selection = 46,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 47,
                        CategoryProductID = 4,
                        Position = 10,
                        Selection = 47,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 48,
                        CategoryProductID = 4,
                        Position = 11,
                        Selection = 48,
                        Quantity = 1
                    },
                    // Snack salati
                    new ProductCategoryProductPosition
                    {
                        ProductID = 49,
                        CategoryProductID = 5,
                        Position = 1,
                        Selection = 59,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 50,
                        CategoryProductID = 5,
                        Position = 2,
                        Selection = 50,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 51,
                        CategoryProductID = 5,
                        Position = 3,
                        Selection = 51,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 52,
                        CategoryProductID = 5,
                        Position = 4,
                        Selection = 52,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 53,
                        CategoryProductID = 5,
                        Position = 5,
                        Selection = 53,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 54,
                        CategoryProductID = 5,
                        Position = 6,
                        Selection = 54,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 55,
                        CategoryProductID = 5,
                        Position = 7,
                        Selection = 55,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 56,
                        CategoryProductID = 5,
                        Position = 8,
                        Selection = 56,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 57,
                        CategoryProductID = 5,
                        Position = 9,
                        Selection = 57,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 58,
                        CategoryProductID = 5,
                        Position = 10,
                        Selection = 58,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 59,
                        CategoryProductID = 5,
                        Position = 11,
                        Selection = 59,
                        Quantity = 1
                    },
                    new ProductCategoryProductPosition
                    {
                        ProductID = 60,
                        CategoryProductID = 5,
                        Position = 12,
                        Selection = 60,
                        Quantity = 1
                    }
                );
                #endregion

                context.SaveChanges();
            }
        }
    }
}
