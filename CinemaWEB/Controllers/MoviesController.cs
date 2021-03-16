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
        //   model.ListOfMovies = movie.GetAllMovies();
            if (id.HasValue)
            {
                model.ActiveMovie = movie.GetMovieById(id.Value);
                model.AvailableTime = timetable.GetMovieTimes(id.Value);
                
                model.MovieCategory = categories.GetCategory(model.ActiveMovie.CategoryId);

                //DateTime selectedDT = DateTime.Parse(model.SelectedTime.Value);
                DateTime selectedDT = model.SelectedTime.Value;
                    model.SelectedTimetable = timetable.GetTimetable(model.ActiveMovie.Id, selectedDT );
               
                
              
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Movie(int id)
        {
            if (ModelState.IsValid)
            {
                try
                { 
                    bookings.BookMovie(id);

                    return RedirectToAction(nameof(Categories));
                }
                catch (Exception ex)
                {
                     ModelState.AddModelError("validation", ex.Message);
                }
            }

            return View(nameof(Index));
        }
    }
}

    



