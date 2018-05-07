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
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = GetMovies();

            return View(movies);
        }

        public ActionResult MovieDetails(int? id)
        {
            var movies = GetMovies();

            if(id == null || movies.All(m => m.Id != id))
            {
                return new HttpNotFoundResult();
            }
            var movie = movies.FirstOrDefault(m => m.Id == id);

            return View(movie);
        }


        public ActionResult Random()
        {
            var randomMovie = GetRandomMovie();

            return View(randomMovie);
        }

        private List<Movie> GetMovies()
        {
            List<Movie> movies = _context.Movies.Include("Genre").ToList();
            return movies;
        }

        private Movie GetRandomMovie()
        {
            var movies = GetMovies();
            if (movies.Count == 0) return null;

            var randomIndex = new Random().Next(movies.Count);
            var randomMovie = movies.ElementAtOrDefault(randomIndex);

            return randomMovie;
        }
    }
}