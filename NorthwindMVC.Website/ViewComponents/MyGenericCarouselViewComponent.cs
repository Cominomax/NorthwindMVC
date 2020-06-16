using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Website.Models;

namespace NorthwindMVC.Website.ViewComponents
{
    public class MyGenericCarouselViewComponent : ViewComponent
    {
        public MyGenericCarouselViewComponent()
        {
        }

        public IViewComponentResult Invoke(CarouselViewModel toDisplay)
        {
            return View(toDisplay);
        }
    }
}
