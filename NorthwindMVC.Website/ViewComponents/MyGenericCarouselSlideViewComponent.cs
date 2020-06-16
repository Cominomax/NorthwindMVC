using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models;
using NorthwindMVC.Website.Models.Base;
using System.Collections.Generic;

namespace NorthwindMVC.Website.ViewComponents
{
    public class MyGenericCarouselSlideViewComponent : ViewComponent
    {
        public MyGenericCarouselSlideViewComponent()
        {
        }

        public IViewComponentResult Invoke(IList<ICanShowAsCard> listToDisplay)
        {
            return View(listToDisplay);
        }
    }
}
