using Northwind.Entities;
using NorthwindMVC.Website.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Website.Models
{
    public class HomepageViewModel
    {
        public HomepageViewModel(List<ICanShowAsCard> lists1, List<ProductViewModel> lists2)
        {
            Categories = lists1;
            Products = lists2;
            CreateRandomCategoryShowcase(lists1);
            CreateRandomSupplierShowcase();

            ProductsWithLittleLeft = Products.Where(p => p.AmountLeft < 10).ToList<ICanShowAsCard>();
            ProductsLessThanPrice = Products.Where(p => p.Price < 10).ToList<ICanShowAsCard>();
        }

        private void CreateRandomSupplierShowcase()
        {
            var SupplierWithMoreThan4Products = Products.GroupBy(p => p.SupplierId).Where(grouping => grouping.Count() > 4).Select(grouping => grouping.Key).ToArray();
            var randSupplier = new Random().Next(0, SupplierWithMoreThan4Products.Count()-1);
            var productsBySupplier = Products.Where(p => p.SupplierId == SupplierWithMoreThan4Products[randSupplier]);
            ShowcasedSupplier = productsBySupplier.First().SupplierName;
            ProductsBySupplier = productsBySupplier.ToList<ICanShowAsCard>();
        }

        private void CreateRandomCategoryShowcase(List<ICanShowAsCard> lists1)
        {
            var randCategory = new Random().Next(0, lists1.Count);
            ShowcasedCategory = Categories[randCategory].Title;
            ProductsByCategory = Products.Where(p => p.CategoryId.Value == randCategory).ToList<ICanShowAsCard>();
        }

        public IList<ICanShowAsCard> Categories { get; set; }
        public IList<ProductViewModel> Products { get; set; }

        public string ShowcasedCategory { get; private set; }
        public IList<ICanShowAsCard> ProductsByCategory { get; private set;  }
        public string ShowcasedSupplier { get; private set; }
        public IList<ICanShowAsCard> ProductsBySupplier { get; private set; }

        public IList<ICanShowAsCard> ProductsWithLittleLeft { get; }

        public IList<ICanShowAsCard> ProductsLessThanPrice { get; set; }
    }
}
