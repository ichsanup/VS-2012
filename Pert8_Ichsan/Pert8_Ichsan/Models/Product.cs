using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pert8_Ichsan.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Stock { set; get; }
    }
}