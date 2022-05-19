using Microsoft.AspNetCore.Mvc;
using MoviesWeb.Data;
using MoviesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class OperationsController : Controller
    {
        //using this to save the data from the DbContext
        private readonly MovieDbContext _context;
        public OperationsController(MovieDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //Passing movieModels to the view to show the list of data within the db
            IEnumerable<MovieModel> movieModels = _context.Order;
            return View(movieModels);
        }
    }
}
