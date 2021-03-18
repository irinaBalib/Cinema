using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA.Managers;
using CinemaWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWEB.Controllers
{
    public class MoviesController : Controller
    {
        private CategoryManager categories = new CategoryManager();
        private MovieManager movie = new MovieManager();
        private TimetableManager timetable = new TimetableManager();
        private BookingsManager bookings = new BookingsManager();
        public IActionResult Categories(int? id)
        {
            CategoriesModel model = new CategoriesModel();
            model.ListOfCategories = categories.GetAllCategories();
            if (id.HasValue)
            {
                model.ActiveCategory = categories.GetCategory(id.Value);
                model.ListOfMovies = movie.GetMoviesByCategory(id.Value);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Movie(int? id)
        {
          MovieModel model = new MovieModel();
           
            if (id.HasValue)
            {
                model.ActiveMovie = movie.GetMovieById(id.Value);
                   model.AvailableTimetables = timetable.GetMovieTimetable(id.Value);

                       model.MovieCategory = categories.GetCategory(model.ActiveMovie.CategoryId);
             }
                return View(model);
        }

        [HttpPost]
        public IActionResult Movie(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                try
                { 
                    bookings.BookMovie(model.SelectedTimeId.Value);

                    return RedirectToAction("UserBookings", "Booking" );
                }
                catch (Exception ex)
                {
                     ModelState.AddModelError("validation", ex.Message);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}

    



