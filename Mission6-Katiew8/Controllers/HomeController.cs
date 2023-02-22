using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_Katiew8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Mission6_Katiew8.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext blahContext { get; set; }

        public HomeController(MovieContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FillOutForm()
        {
            ViewBag.Categories = blahContext.Category.ToList();
            return View("MovieForm");
        }
        [HttpPost]
        public IActionResult FillOutForm(MovieResponse response)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(response);
                blahContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = blahContext.Category.ToList();
                return View(response);
            }
            
        }

        public IActionResult Podcast()
        {
            return View("Podcast");
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = blahContext.Category.ToList();
            var application = blahContext.Responses.Single(x => x.MovieId == applicationid);
            return View("MovieForm", application);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");

        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = blahContext.Responses.Single(x => x.MovieId == applicationid); 
            return View("Delete", application);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse blah)
        {
            blahContext.Responses.Remove(blah);
            blahContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
