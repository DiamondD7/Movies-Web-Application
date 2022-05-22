using Microsoft.AspNetCore.Mvc;
using MoviesWeb.Data;
using MoviesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class ListController : Controller
    {
        private readonly MovieDbContext _context;
        public ListController(MovieDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<MovieModel> movieModels = _context.Order;
            return View(movieModels);
        }
    }
}
