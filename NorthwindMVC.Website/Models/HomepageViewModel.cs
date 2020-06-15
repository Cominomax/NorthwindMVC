using Northwind.Entities;
using System.Collections.Generic;

namespace NorthwindMVC.Website.Models
{
    public class HomepageViewModel
    {
        public List<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
