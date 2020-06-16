using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models.Base;

namespace NorthwindMVC.Website.ViewComponents
{
    public class BigCardViewComponent : ViewComponent
    {
        public BigCardViewComponent()
        {
        }

        public IViewComponentResult Invoke(ICanShowAsCard element)
        {
            return View(element);
        }
    
    }
}
