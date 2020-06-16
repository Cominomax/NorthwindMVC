using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models.Base;
using System.Collections.Generic;

namespace NorthwindMVC.Website.ViewComponents
{
    public class MyGenericCarouselMultiItemSlideViewComponent : ViewComponent
    {
        public MyGenericCarouselMultiItemSlideViewComponent()
        {
        }

        public IViewComponentResult Invoke(IList<ICanShowAsCard> listToDisplay)
        {
            return View(listToDisplay);
        }
    }
}
