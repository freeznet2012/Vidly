using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        [Route("random")]
        public IActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}

            };
            var randomMovie = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovie);
        }

        [Route("released/{year}/{month}")]
        public IActionResult ByReleaseDate(int? year, int? month)
        {
            if (!year.HasValue)
                year = 2020;
            if (!month.HasValue)
                month = 1;
            return Content("Year: " + year + " Month: " + month);
        }
    }
}
