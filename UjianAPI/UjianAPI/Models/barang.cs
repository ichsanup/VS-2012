using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UjianAPI.Models
{
    public class barang
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }   
    }
}