using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CinemaWEB.Models;
using CINEMA;

namespace CinemaWEB.Controllers
{
    public class HomeController : Controller
    {
        //private MovieManager mm = new MovieManager();
        private GettingData gd = new GettingData();
        public IActionResult Index()   
        {
            //var data = mm.GetAllMovies();
          
            return View(gd.ListOfMovies);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
