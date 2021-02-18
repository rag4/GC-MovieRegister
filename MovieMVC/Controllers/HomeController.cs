using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieMVC.Models;

namespace MovieMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View();
        }

        public IActionResult Result(Result r)
        {
            if(r.title.Length > 50)
            {
                TempData["msg"] = "<script>alert('Movie Title too long.');</script>";
                return View("Movies");
            }

            if(r.year < 1880)
            {
                TempData["msg"] = "<script>alert('Movie year before 1880.');</script>";
                return View("Movies");
            }

            int currentDate = int.Parse(DateTime.Now.Year.ToString());
            if(r.year > currentDate)
            {
                TempData["msg"] = "<script>alert('Movie year after current year.');</script>";
                return View("Movies");
            }

            return View(r);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
