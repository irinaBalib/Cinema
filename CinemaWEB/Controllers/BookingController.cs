using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CINEMA.Managers;
using CinemaWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWEB.Controllers
{
    public class BookingController : Controller
    {
        private BookingsManager bm = new BookingsManager();
        private TimetableManager tm = new TimetableManager();
      
        /*
        [HttpGet]
        public IActionResult CreateBook(DateTime t)
        {
            DataModel model = new DataModel();
            model.SelectedTime = t;
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateBook( DataModel model)
        {
            
            if (ModelState.IsValid)
            {
                model.ActiveTimetable = tm.GetTimetable(model.ActiveMovie.CategoryId, model.SelectedTime);
                
            }
           
            return View(model);
       
        }
        public IActionResult SubmitBook(int? id)
        {
            DataModel model = new DataModel();
            if (id.HasValue)
            {
                var result = bm.BookMovie(model.ActiveTimetable.Id);
            if (String.IsNullOrEmpty(result))
            {
                // send to start
                return RedirectToAction("Index");
            }
                else
            {
                ModelState.AddModelError("validation", result);
            }
            }
            
            return RedirectToAction(nameof(UserBookings));
        }
        */
        public IActionResult UserBookings()
        {
            DataModel model = new DataModel();
            model.ListOfBookings = bm.GetAllBookings();
            return View(model);
        }
    }
}
