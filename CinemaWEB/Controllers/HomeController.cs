using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CinemaWEB.Models;
using CINEMA.Managers;
using CINEMA.DB;

namespace CinemaWEB.Controllers
{
    public class HomeController : Controller
    {
        private MovieManager mm = new MovieManager();
        private CategoryManager cm = new CategoryManager();
        
        public IActionResult Index()   
        {
            var data = mm.GetAllMovies();
          
            return View(data);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
