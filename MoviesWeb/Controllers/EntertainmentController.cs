using Microsoft.AspNetCore.Mvc;
using MoviesWeb.Data;
using MoviesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class EntertainmentController : Controller
    {
        private readonly MovieDbContext _context;
        public EntertainmentController(MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(MovieModel movies, string button)
        {
            if (button == "Horror")
            {
                movies.MovieType = "Horror";
            }
            else if(button == "Action")
            {
                movies.MovieType = "Action";
            }
            else if (button == "Adventure")
            {
                movies.MovieType = "Adventure";
            }
            else if (button == "Comedy")
            {
                movies.MovieType = "Comedy";
            }
            else if (button == "Thriller")
            {
                movies.MovieType = "Thriller";
            }
            else if (button == "Sci-Fi")
            {
                movies.MovieType = "Sci-Fi";
            }
            else if (button == "Documentary")
            {
                movies.MovieType = "Documentary";
            }
            else if (button == "Bio")
            {
                movies.MovieType = "Bio";
            }
            else
            {
                IEnumerable<MovieModel> mov = _context.Order;
                return View(mov);
            }
            IEnumerable<MovieModel> movie = _context.Order;
            var genreSelected = movie.Where(c => c.MovieType == movies.MovieType);
            return View(genreSelected);
        }


/*        [HttpPost]
        public IActionResult Index(MovieModel movieModel, string button, string idk)
        {

            if (button == "Horror")
            {
                movieModel.MovieType = "Horror";
            }
            return View(movieModel.MovieType);

        }*/


    }
}
