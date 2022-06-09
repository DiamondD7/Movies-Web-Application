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
            if (button == CheckString(button))
            {
                movies.MovieType = CheckString(button);
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
        public string CheckString(string genre)
        {
            if (genre == "Horror")
            {
                return "Horror";
            }
            else if (genre == "Action")
            {
                return "Action";
            }
            else if (genre == "Adventure")
            {
                return "Adventure";
            }
            else if (genre == "Comedy")
            {
                return "Comedy";
            }
            else if (genre == "Thriller")
            {
                return "Thriller";
            }
            else if (genre == "Sci-Fi")
            {
                return "Sci-Fi";
            }
            else if (genre == "Documentary")
            {
                return "Documentary";
            }
            return "Bio";
        }


    }
}
