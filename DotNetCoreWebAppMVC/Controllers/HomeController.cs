using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebAppMVC.Models;

namespace DotNetCoreWebAppMVC.Controllers {
    public class HomeController : Controller {
        //public IActionResult Index() {
        //    return View();
        //}

        private readonly DotNetCoreWebAppMVC.Data.ApplicationDbContext _context;

        public HomeController(DotNetCoreWebAppMVC.Data.ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            /*return View(_context.Post.ToList());*/ //.ToListAsync());
            return View(_context.Post
                .OrderByDescending(x => x.CreationDate)
                .Take(5)
                .ToList()
            );
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
