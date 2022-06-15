using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesWeb.Data;
using MoviesWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class HomeController : Controller
    {
        public IEnumerable<Popular> popular { get; set; }
        public IEnumerable<TopMovies> topMovies { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MovieDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        private readonly MovieDbContext _context;
        public IActionResult Index()
        {
            /*IEnumerable<MovieModel> movieModels = _context.Order;*/
            topMovies = _context.TopMoviesDB;
            popular = _context.populars;
            dynamic mymodel = new ExpandoObject();
            mymodel.TopMovies = topMovies;
            mymodel.Popular = popular;
            return View(mymodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
