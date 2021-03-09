using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWEB.Controllers
{
    public class MoviesController : Controller
    {
        private CategoryManager categories = new CategoryManager();
        private MovieManager movie = new MovieManager();
        public IActionResult Categories()
        {
            var data = categories.GetAllCategories();
            return View(data);
        }

        public IActionResult ViewByCategory(int id)
        {
            var data = movie.GetMoviesByCategory(id);
            return View(data);
        }
        public IActionResult Movie(string title)
        {
           var data = movie.GetMovieInfo(title);
            return View(data);
        }

        public IActionResult SelectTime(string datetime)
        {
            
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }
    }
}
