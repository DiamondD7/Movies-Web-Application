using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Controllers
{
    public class EntertainmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
