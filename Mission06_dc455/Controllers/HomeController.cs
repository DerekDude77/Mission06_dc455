using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_dc455.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dc455.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieApplicationContext _MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieApplicationContext x)
        {
            _logger = logger;
            _MovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse response)
        {
            _MovieContext.Add(response);
            _MovieContext.SaveChanges();
            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
