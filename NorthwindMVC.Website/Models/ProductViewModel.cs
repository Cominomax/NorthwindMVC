using NorthwindDAL.Entities;
using NorthwindMVC.Website.Models.Base;

namespace NorthwindMVC.Website.Models
{
    public class ProductViewModel : ICanShowAsCard
    {
        public ProductViewModel(Product product, string webRootPath)
        {
            Id = product.ProductID;
            Price = product.UnitPrice;
            Title = product.ProductName;
            AmountLeft = product.UnitsInStock;
            CategoryId = product.CategoryID;
            SupplierId = product.SupplierID;
            SupplierName = product.Supplier?.CompanyName;
            var path = System.IO.Path.Combine(webRootPath, "images", "Products", $"product{Id}.jpg");
            Image = System.IO.File.Exists(path) ? System.IO.Path.Combine("Products", $"product{Id}.jpg") : System.IO.Path.Combine("Products", $"Default.jpg");
        }

        public int Id { get; }

        public int? CategoryId { get; }

        public int? SupplierId { get; }
        public string SupplierName { get; }
        public string Title { get; }

        public string Text => $"Price: {Price} - In Stock: {AmountLeft}";

        public string Image { get; }

        public decimal? Price { get; }

        public short? AmountLeft { get; }

        public string Controller => "Products";

        public string Action => "Details";
    }
}
