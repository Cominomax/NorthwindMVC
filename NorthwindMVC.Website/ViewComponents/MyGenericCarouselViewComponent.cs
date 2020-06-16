using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindMVC.Website.ViewComponents
{
    public class MyGenericCarouselViewComponent : ViewComponent
    {
        public MyGenericCarouselViewComponent()
        {
        }

        public IViewComponentResult Invoke(IList<ICanShowAsCard> listToDisplay)
        {
            return View(listToDisplay);
        }
    }
}
