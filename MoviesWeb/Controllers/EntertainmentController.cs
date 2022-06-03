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

        public IActionResult Index()
        {
            IEnumerable<MovieModel> movie = _context.Order;
            var genreSelected = movie.Where(x => x.MovieType == "Horror");
            return View(genreSelected);
        }

        public IActionResult Genre(MovieModel movieModel)
        {
            return View(movieModel.MovieType);
        }
    }
}
