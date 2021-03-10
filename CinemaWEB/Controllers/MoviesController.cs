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
        private BookingsManager bm = new BookingsManager();
        public IActionResult Categories()
        {
            var data = categories.GetAllCategories();
            return View(data);
        }

        public IActionResult UserBookings()
        {
            var data = bm.GetAllBookings();
            return View(data);
        }

        public IActionResult ViewByCategory(int id)
        {
            var data = movie.GetMoviesByCategory(id);
            return View(data);
        }
        public IActionResult Movie(int id)
        {
           var data = movie.GetMovieInfo(id);
            return  View(data);
              
        }

        public IActionResult SelectTime(DateTime datetime)
        {
            //use to create an entry to the MyBookings db
            return View();
        }

        public IActionResult Book(string datetime, int movieId)
        {
            return View();
        }
    }
}
