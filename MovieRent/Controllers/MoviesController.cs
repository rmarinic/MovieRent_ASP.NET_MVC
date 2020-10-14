using MovieRent.Models;
using MovieRent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRent.Controllers
{
    public class MoviesController : Controller
    {
        //HARDCODED FOR NOW, TODO: DATABASE
        List<Movie> movies = new List<Movie>
        {
            new Movie { id=0, name="Inception" },
            new Movie { id=1, name="Shutter Island" },
            new Movie { id=2, name="Primer" },
            new Movie { id=3, name="The Machinist" },
            new Movie { id=4, name="Interstellar" }
        };

        public ActionResult Index()
        {
            var viewModel = new MovieViewModel
            {
                movieList = movies
            };
            return View(viewModel);
        }
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { name = "Inception" };
            var customers = new List<Customer>
            {
                new Customer { name="Customer 1"},
                new Customer { name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
            };

            return View (viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}