using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models.Base;

namespace NorthwindMVC.Website.ViewComponents
{
    public class BriefElementCardViewComponent : ViewComponent
    {
        public BriefElementCardViewComponent()
        {
        }

        public IViewComponentResult Invoke(ICanShowAsCard element)
        {
            return View(element);
        }
    }
}
