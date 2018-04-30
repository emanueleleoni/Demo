﻿using LK2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Diagnostics;
using System.IO;

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
            ViewBag.Categories = repoCat.GetList(1);
            ViewBag.Products = repoProd.GetList(1);

            return View();
        }

        public void Python(){
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();

                start.FileName = @"C:\Users\emanl\AppData\Local\Programs\Python\Python36-32\python.exe"; //full path to python.exe
                                                            //start.FileName = @"C:\Windows\system32\cmd.exe";
                                                            //start.Arguments = string.Format("{0} {1} {2} {3}", @"C:\Users\J1035\Documents\Python27\GiveX_python\test.py", "123456789", "603628982592000186162", 20.00);
                start.Arguments = @"C:\Users\emanl\Downloads\HelloWorld.py";

                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                using (Process process = Process.Start(start))
                using (StreamReader reader = process.StandardOutput)
                {
                    string foo = reader.ReadToEnd();
                    ViewBag.Text += foo;
                }

            }
            catch (Exception ex)
            {
                var foo = ex.Message;
            }
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