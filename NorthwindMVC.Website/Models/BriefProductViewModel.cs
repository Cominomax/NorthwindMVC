using Northwind.Entities;
using NorthwindMVC.Website.Models.Base;

namespace NorthwindMVC.Website.Models
{
    public class BriefProductViewModel : ICanShowAsCard
    {
        private decimal? _price;
        private short? _amountLeft;

        public BriefProductViewModel(Product product, string webRootPath)
        {
            Id = product.ProductID;
            _price = product.UnitPrice;
            Title = product.ProductName;
            _amountLeft = product.UnitsInStock;

            var path = System.IO.Path.Combine(webRootPath, "images", "Products", $"product{Id}.jpg");
            Image = System.IO.File.Exists(path) ? System.IO.Path.Combine("Products", $"product{Id}.jpg") : System.IO.Path.Combine("Products", $"Default.jpg");
        }

        public int Id { get; set; }

        public string Title { get; }

        public string Text => $"Price: {_price} - In Stock: {_amountLeft}";

        public string Image { get; }

        public string Controller => "Products";

        public string Action => "Details";
    }
}
