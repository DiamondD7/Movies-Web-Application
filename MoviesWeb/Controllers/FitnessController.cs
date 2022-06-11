using Microsoft.AspNetCore.Mvc;
using MoviesWeb.Data;
using MoviesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class FitnessController : Controller
    {
        private readonly MovieDbContext _context;
        public FitnessController(MovieDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable <MovieModel> movieModel = _context.Order;
            var fitGenre = movieModel.Where(x => x.MovieType == "Fitness");
            return View(fitGenre);
        }
    }
}
