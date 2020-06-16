using Northwind.Entities;
using NorthwindMVC.Website.Models.Base;
using System.Collections.Generic;

namespace NorthwindMVC.Website.Models
{
    public class CategoryViewModel : ICanShowAsCard
    {
        public CategoryViewModel(Category category, string webRootPath = "")
        {
            Id = category.CategoryID;
            Title = category.CategoryName;
            Text = category.Description;
            Image = $"category{Id}.jpeg";
            if (category.Products != null && !string.IsNullOrEmpty(webRootPath))
            {
                BriefProducts = new List<ICanShowAsCard>();
                foreach (var product in category.Products)
                {
                    BriefProducts.Add(new ProductViewModel(product, webRootPath));
                }
            }
        }

        public int Id { get; }

        public string Title { get; }

        public string Text { get; }

        public string Image { get; }

        public IList<ICanShowAsCard> BriefProducts { get; set; }

        public string Controller => "Categories";

        public string Action => "Details";
    }
}
