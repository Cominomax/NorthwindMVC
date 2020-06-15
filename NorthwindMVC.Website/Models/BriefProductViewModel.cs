using Northwind.Entities;

namespace NorthwindMVC.Website.Models
{
    public class BriefProductViewModel
    {
        public BriefProductViewModel(Product product)
        {
            Id = product.ProductID;
            Price = product.UnitPrice;
            Name = product.ProductName;
            AmountLeft = product.UnitsInStock;
        }

        public int Id { get; set; }
        public decimal? Price { get; }
        public string Name { get; }
        public short? AmountLeft { get; }
    }
}
