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
        private BookingsManager bm = new BookingsManager();


        public IActionResult Categories(int? id)
        {
            DataModel model = new DataModel();
            model.ListOfCategories = categories.GetAllCategories();
            if (id.HasValue)
            {
                model.ActiveCategory = categories.GetCategory(id.Value);
                
                model.ListOfMovies = movie.GetMoviesByCategory(id.Value);
            }
            return View(model);
        }
        public IActionResult Movie(int? id)
        {
            DataModel model = new DataModel();
            model.ListOfMovies = movie.GetAllMovies();
            if (id.HasValue)
            { 
                model.ActiveMovie = movie.GetMovieById(id);
               
            }
            return View(model);
        }
    }
        

        //public IActionResult UserBookings()
        //{
        //    var data = bm.GetAllBookings();
        //    return View(data);
        //}

        //    //public IActionResult ViewByCategory(int id)
        //    //{
        //    //    var data = movie.GetMoviesByCategory(id);
        //    //    return View(data);
        //    //}
      

        //public IActionResult SelectTime(DateTime datetime)
        //{
        //    //use to create an entry to the MyBookings db
        //    return View();
        //}

        //public IActionResult Book(string datetime, int movieId)
        //{
        //    return View();
        //}
    
}
