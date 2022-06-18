using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using ujicoba.Models;

namespace ujicoba.Controllers
{
    public class ProductController : Controller
    {
        private Uri api_url = new Uri("http://localhost:16879/");
        // GET: Product /
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.api_url;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/products/").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            }
            else
            {
                ViewBag.products = "Produk tidak ditemukan";
            }

            return View();
        }

        //GET: /Product/Details/2

        public ActionResult Details(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.api_url;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/products/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.product = response.Content.ReadAsAsync<Product>().Result;
            }
            else
            {
                ViewBag.product = "Error";
            }

            return View();
        }
    }
}
