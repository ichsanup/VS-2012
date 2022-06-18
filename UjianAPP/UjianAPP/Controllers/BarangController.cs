using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using UjianAPP.Models;

namespace UjianAPP.Controllers
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
                ViewBag.barang = response.Content.ReadAsAsync<IEnumerable<barang>>().Result;
            }
            else
            {
                ViewBag.barang = "Produk tidak ditemukan";
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
                ViewBag.product = response.Content.ReadAsAsync<barang>().Result;
            }
            else
            {
                ViewBag.product = "Error";
            }

            return View();
        }
    }
}
