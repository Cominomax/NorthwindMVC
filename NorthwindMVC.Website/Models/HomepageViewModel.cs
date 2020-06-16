using Northwind.Entities;
using NorthwindMVC.Website.Models.Base;
using System.Collections.Generic;

namespace NorthwindMVC.Website.Models
{
    public class HomepageViewModel
    {
        public IList<ICanShowAsCard> Categories { get; set; }
        public IList<BriefProductViewModel> Products { get; set; }
    }
}
