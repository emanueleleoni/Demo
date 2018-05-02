using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LK2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace lk2_demo.Controllers
{
    public class AdminController : Controller
    {
        private readonly IStringLocalizer<AdminController> _localizer;
        /// <summary>
        /// Our Repostory implementation.
        /// </summary>
        private ICategoryProductRepository repoCat;
        private IProductRepository repoProd;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryProductRepository"></param>
        /// <param name="productRepository"></param>
        public AdminController(IStringLocalizer<AdminController> localizer,
                              ICategoryProductRepository categoryProductRepository,
                              IProductRepository productRepository)
        {
            _localizer = localizer;

            repoCat = categoryProductRepository;
            repoProd = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string password){
            if (!string.IsNullOrEmpty(password))
            {
                if (password.Equals("1234"))
                    return RedirectToAction("Selection");
                else
                    ViewBag.Error = "Password errata! Si prega di riprovare";
            }

            return View();
        }

        public IActionResult Selection(){
            ViewBag.Categories = repoCat.GetList(1);
            ViewBag.Products = repoProd.GetList(1);
            
            return View();
        }

        [HttpPost]
        public string Update(int categoryProductID, int productID, double price){
            repoProd.UpdateProduct(productID, price);

            return "ok";
        }
    }
}