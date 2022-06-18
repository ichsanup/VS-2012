using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsiteRazor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListCustomers() {
            List<MyWebsiteRazor.Models.Customer> customers = new List<MyWebsiteRazor.Models.Customer>();

            customers.Add(new MyWebsiteRazor.Models.Customer()
            {
                Id = 1,
                CompanyName = "Volvo",
                ContactNo = "123-0123-0001",
                ContactPerson = "Gustav Larson",
                Description = "Volvo Car Corporation or Volvo PersonVagnar AB, is Scandinavian manufacturer founded 1937"
            });
            customers.Add(new MyWebsiteRazor.Models.Customer()
            {
                Id = 2,
                CompanyName = "BMW",
                ContactNo = "999-987-9898",
                ContactPerson = "Franz Josef Poop",
                Description = "Bayerische Motoren Werke Ag (BMW English = Bavarian Motor Works) is a German Automobile, Motorcycle and engine manufacturing company founded in 1917"
            });
            customers.Add(new MyWebsiteRazor.Models.Customer()
            {
                Id = 3,
                CompanyName = "Audi",
                ContactNo = "983-2222-1212",
                ContactPerson = "Karl Benz",
                Description = "Is a multinational division of the German manufacturer Daimer AG"
            });
            return View(customers);
        }
    }
}
