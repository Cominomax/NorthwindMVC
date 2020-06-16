using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindMVC.Website.Models.Base
{
    public interface IAmClickable
    {
        string Controller { get; }
        string Action { get; }
    }
}
