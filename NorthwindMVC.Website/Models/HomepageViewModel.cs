using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindMVC.Website.Models
{
    public class HomepageViewModel
    {
        public List<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
