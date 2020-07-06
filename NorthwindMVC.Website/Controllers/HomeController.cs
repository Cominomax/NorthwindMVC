using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NorthwindMVC.DAL;
using NorthwindMVC.Website.Models;
using NorthwindMVC.Website.Models.Base;

namespace NorthwindMVC.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindDB _context;
        private readonly IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, NorthwindDB context, IWebHostEnvironment env)
        {
            _logger = logger;
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var cat = await _context.Categories.ToListAsync();
            var prod = await _context.Products.Include(p => p.Supplier).Include(p => p.Category).Where(p => p.UnitsInStock > 0).ToListAsync();
            var homeViewModel = new HomepageViewModel(cat.Select(c => new CategoryViewModel(c)).ToList<ICanShowAsCard>(), prod.Select(p => new ProductViewModel(p, _env.WebRootPath)).ToList());
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
