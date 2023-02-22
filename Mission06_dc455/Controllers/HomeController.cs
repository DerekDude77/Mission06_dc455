using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public MovieApplicationContext MovieContext { get; set; }

        public HomeController(MovieApplicationContext x)
        {
            MovieContext = x;
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
            ViewBag.Categories = MovieContext.Category.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse response)
        {
            if(ModelState.IsValid)
            {
                MovieContext.Add(response);
                MovieContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = MovieContext.Category.ToList();

                return View(response);
            }

            
        }

        public IActionResult MovieTable()
        {
            var table = MovieContext.responses
                .Include(x => x.Category)
                .ToList();
            // Where(x => x.(filter criteria) == (value))
            // OrderBy(x => x.(ordered criteria))

            return View(table);
        }

        [HttpGet]
        public IActionResult Edit(int entryid)
        {
            ViewBag.Categories = MovieContext.Category.ToList();

            var Movie = MovieContext.responses.Single(x => x.EntryID == entryid);

            return View("MovieApplication", Movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse edit)
        {
            MovieContext.Update(edit);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieTable");
        }
        [HttpGet]
        public IActionResult Delete(int entryid)
        {
            var Movie = MovieContext.responses.Single(x => x.EntryID == entryid);
            return View(Movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse response)
        {
            MovieContext.responses.Remove(response);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieTable");
        }
    }
}
