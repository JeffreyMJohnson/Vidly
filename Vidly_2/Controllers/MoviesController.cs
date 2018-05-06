using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2.Models;

namespace Vidly_2.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> _movies = new List<Movie>()
        {
            new Movie(){Id = 0, Name = "Shrek!"},
            new Movie(){Id = 1, Name = "Heavy Metal"},
            new Movie(){Id = 2, Name = "2001 A Space Oddysey"}
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(_movies);
        }


        public ActionResult Random()
        {
            Movie movie = new Movie(){Name = "Shrek!"};

            return View(movie);
        }
    }
}