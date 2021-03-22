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
        
        
        public IActionResult UserBookings()
        {
            UserBookingsModel model = new UserBookingsModel();
            model.ListOfBookings = bm.GetAllBookings();
             return View(model);
        }

        public IActionResult Remove(int id)
        {
            bm.RemoveBooking(id);

            return RedirectToAction(nameof(UserBookings));
        }
        public IActionResult Add(int id)
        {
            bm.AddBooking(id);

            return RedirectToAction(nameof(UserBookings));
        }

      
    }
}
