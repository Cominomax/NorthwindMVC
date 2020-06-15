﻿using System.Collections.Generic;

namespace Northwind.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
