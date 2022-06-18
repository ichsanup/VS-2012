using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pert7_IchsanUstaf.Models
{
    public class Product
    {
        
        public int Id {get;set;}
        public string Name {get;set;}
        public double Price {get;set;}
        public int Stock {get;set;}    
    }
}