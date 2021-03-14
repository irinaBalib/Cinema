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

        [HttpGet]
        public IActionResult Book()
        {
            DataModel model = new DataModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Book(DataModel model)
        {
            // if valid -> save and send to another page
            if (ModelState.IsValid)
            {
                // manager call
                // manager.CreateNew(model.Title);
                // custom validations
                // ...
                //ModelState.AddModelError("validation", "Topic already exists!");

                // send to start
                //  return RedirectToAction("Topics", "News"); 
                // manager call
                int movieId = model.ActiveMovie.Id;
                DateTime dt = model.SelectedTime;
                model.ActiveTimetable = tm.GetTimetable(movieId, dt);
                var result = bm.BookMovie(model.ActiveTimetable);///???
                if (String.IsNullOrEmpty(result))
                {
                    // send to start
                    return RedirectToAction("UserBookings");
                }
                else
                {
                    ModelState.AddModelError("validation", result);
                }
            }

            // if not valid -> return back to the same view
            return View(model);
       
        //public IActionResult Book(DateTime selectedTime)
        //{
        //    DataModel model = new DataModel();

        //    if (selectedTime != null)
        //    {
        //        model.SelectedMovie = tm.GetTimetableId(model.ActiveMovie.Id, selectedTime);

        //    }
        //    return RedirectToAction(nameof(UserBookings));
        }
        //public IActionResult SubmitBook()
        //{
        //    DataModel model = new DataModel();

        //    if (selectedTime != null)
        //    {
        //        model.SelectedMovie = tm.GetTimetableId(id, selectedTime);

        //    }
        //    return RedirectToAction(nameof(UserBookings));
        //}

        public IActionResult UserBookings()
        {
            DataModel model = new DataModel();
            model.ListOfBookings = bm.GetAllBookings();
            return View(model);
        }
    }
}
