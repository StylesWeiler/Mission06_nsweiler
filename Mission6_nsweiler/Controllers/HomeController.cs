using Microsoft.AspNetCore.Mvc;
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
    public class HomeController : Controller // inherits from base controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; } // get set properties are already applied with this syntax

        // controller constructor
        public HomeController(ILogger<HomeController> logger,  MovieContext temp)
        {
            _logger = logger;
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
                return View();
            }
 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Error handling
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
