using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindMVC.Website.Models.Base
{
    public interface IPaginatedList<T> : IList<T>, IEnumerable<T>
    {
        int PageSize { get; }
        int PageIndex { get; }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}
