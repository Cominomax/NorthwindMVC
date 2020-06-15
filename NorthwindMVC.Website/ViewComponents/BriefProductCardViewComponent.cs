using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Entities;
using NorthwindMVC.DAL;
using NorthwindMVC.Website.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindMVC.Website.ViewComponents
{
    public class BriefProductCardViewComponent : ViewComponent
    {
        private readonly NorthwindDAL _db;

        public BriefProductCardViewComponent(NorthwindDAL context)
        {
            _db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var item = new BriefProductViewModel(await GetProductAsync(productId));
            return View(item);
        }

        private Task<Product> GetProductAsync(int productId)
        {
            return _db.Products.FirstOrDefaultAsync(p => p.ProductID == productId);
        }
    }
}
