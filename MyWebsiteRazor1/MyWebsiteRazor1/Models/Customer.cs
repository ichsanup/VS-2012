using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebsiteRazor1.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
    }
}