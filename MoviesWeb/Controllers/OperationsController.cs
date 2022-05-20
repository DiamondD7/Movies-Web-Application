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

        //GET
        public IActionResult Index()
        {
            //Passing movieModels to the view to show the list of data within the db
            IEnumerable<MovieModel> movieModels = _context.Order;
            return View(movieModels);
        }

        //GET
        public IActionResult Create()
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieModel movieModel)
        {
            _context.Order.Add(movieModel);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //GET
        public IActionResult Edit(int? id)
        {
            var find = _context.Order.Find(id);
            return View(find);
        }

        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MovieModel movie)
        {
            _context.Order.Update(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var find = _context.Order.Find(id);
            return View(find);
        }

        public IActionResult Delete(MovieModel movies)
        {
            _context.Order.Remove(movies);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
