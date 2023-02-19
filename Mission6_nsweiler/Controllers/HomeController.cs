using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_nsweiler.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq; 
using System.Threading.Tasks;

namespace Mission6_nsweiler.Controllers
{

    // Main controller
    // Linq is the database querying tool
    // C# is case sensitive
    // 
    public class HomeController : Controller // inherits from base controller
    {
        private MovieContext _movieContext { get; set; } // get set properties are already applied with this syntax

        // controller constructor
        public HomeController(MovieContext temp)
        {
            _movieContext = temp; // set the movie context to the variable temp
        }

        public IActionResult Index() // Index page view
        {
            return View();
        }
        public IActionResult Podcast() // Podcast page view
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication() // GET request for Movie application page view
        {
            // View Bag is a dynamic list of variables, in this case categories
            ViewBag.Categories = _movieContext.Categories.ToList(); // since the ViewBag is already passed between Views, it does not need to be included in the return View() statement below

            return View(); // return a different view than the name of the action by adding parameter
        }

        [HttpPost]
        public IActionResult MovieApplication(MovieResponse mr) // POST request for Movie application page view
        {
            
            if (ModelState.IsValid)
            {
                _movieContext.Add(mr); // add changes to the databse (no save)
                _movieContext.SaveChanges(); // saves changes permantently 

                return View("Confirmation", mr); // return a different view than the name of the action
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList(); // since the ViewBag is already passed between Views, it does not need to be included in the return View() statement below

                return View(mr);
            }
 
        } 

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = _movieContext.Responses
                .Include(x => x.category) // this says to grab the category name associated with that dataset and include it
                .OrderBy(x => x.title)
                .ToList(); // var ("variant") is for dynamic variables (value will change over time)

            return View(applications);
;        }

        [HttpGet]
        public IActionResult Edit(int movieId)
        {
            ViewBag.Categories = _movieContext.Categories.ToList(); // since the ViewBag is already passed between Views, it does not need to be included in the return View() statement below

            var application = _movieContext.Responses.Single(x => x.movieId == movieId); // like find, returns a single record
            // lambda is an anyomous function that finds the data specified, which in this case is the categoryId passed to the view that matches in the model and returns the whole object
           
            return View("MovieApplication", application);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse mr)
        {
            _movieContext.Update(mr); // update record
            _movieContext.SaveChanges(); // save update in db

            return RedirectToAction("MovieList"); // calls the MovieList action next
        }

        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var application = _movieContext.Responses.Single(x => x.movieId == movieId); // like find, returns a single record

            return View();
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            _movieContext.Responses.Remove(mr); // remove the movieresponse record from the Responses table
            _movieContext.SaveChanges(); // save the changes made in the database

            return RedirectToAction("MovieList"); // calls the MovieList action next
        }
    }
}
