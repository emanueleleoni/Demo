using LK2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;

namespace LK2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
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
        public HomeController(IStringLocalizer<HomeController> localizer,
                              ICategoryProductRepository categoryProductRepository, 
                              IProductRepository productRepository)
        {
            _localizer = localizer;

            repoCat = categoryProductRepository;
            repoProd = productRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = repoCat.GetList();
            ViewBag.Products = repoProd.GetList();

            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
