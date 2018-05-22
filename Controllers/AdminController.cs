using LK2;
using LK2.Models;
using LK2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lk2_demo.Controllers
{
    public class AdminController : Controller
    {
        private readonly JsonRPC _jsonRPC;
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
                              IProductRepository productRepository,
                              IOptions<JsonRPC> jsonRPC)
        {
            _localizer = localizer;

            repoCat = categoryProductRepository;
            repoProd = productRepository;
            _jsonRPC = jsonRPC.Value;
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
                    return RedirectToAction("Report");
                else
                    ViewBag.Error = "Password errata! Si prega di riprovare";
            }

            return View();
        }

        public IActionResult Selection(){
            ViewBag.Categories = repoCat.GetList(1);
            ViewBag.Products = repoProd.GetAdminList(1);
            
            return View();
        }

        public IActionResult Recipe()
        {
            return View();
        }

        [HttpPost]
        public string Update(int categoryProductID, int productID, double price, int selection, int quantity, int position){
            repoProd.UpdateProduct(productID, categoryProductID, price, selection, quantity, position);

            return "ok";
        }

        [HttpPost]
        public string Delete(int categoryProductID, int productID, int position) {
            repoProd.DeleteProduct(categoryProductID, productID, position);

            return "ok";
        }

        [HttpPost]
        public IActionResult Add(int categoryProductID){
            var product = repoProd.AddProduct(categoryProductID);    

            return PartialView("_AddProduct", product);
        }


        [HttpPost]
        public string Create(int categoryProductID, int productID, int position, int selection, int quantity)
        {
            repoProd.AddProductToCategory(categoryProductID, productID, position, selection, quantity);

            return "ok";
        }

        public IActionResult Report(){

            return View();
        }

        public async Task<string> Close()
        {
            UTF8Encoding enc = new UTF8Encoding();
            string data = "{ \"params\": [" + _jsonRPC.URL_Public + "],\"method\" : \"" + _jsonRPC.URL_Change + "\", \"id\" : \"" + Guid.NewGuid() + "\", \"jsonrpc\": \"2.0\" }";

            //Create request
            WebRequest request = WebRequest.Create(_jsonRPC.Server);
            request.Method = "POST";
            request.ContentType = "application/json";

            //Set data in request
            Stream dataStream = await request.GetRequestStreamAsync();
            dataStream.Write(enc.GetBytes(data), 0, data.Length);


            //Get the response
            WebResponse wr = await request.GetResponseAsync();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<JsonRpc>(content).result;
        }

    }
}