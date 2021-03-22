using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    public class BookingsManager
    {

        public List<UserBookings> GetAllBookings()
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.UserBookings.OrderBy(b => b.TimetableId).ToList();
            }
        }

        public void BookMovie(int id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
               var booking = db.UserBookings.FirstOrDefault(b => b.TimetableId == id);
               
                if (booking == null)
                {
                     db.UserBookings.Add(new UserBookings()
                     {
                        TimetableId = id,
                         Quantity = 1,
                         Price = db.Timetable.FirstOrDefault(t => t.Id == id).Price,
                        Amount = db.Timetable.FirstOrDefault(t => t.Id == id).Price
                     });
                
                }
                else
                {
                    booking.Quantity++;
                    booking.Amount = booking.Quantity * booking.Price;
                }
                db.SaveChanges();
            }
           
        }

        
        public UserBookings RemoveBooking (int id)
        {
            using(CinemaDatabase db = new CinemaDatabase())
            {
                var booking = db.UserBookings.FirstOrDefault(b => b.Id == id);
                if (booking != null && booking.Quantity == 1)
                {
                    db.UserBookings.Remove(booking);
                    db.SaveChanges();
                    return booking;
                }
                else if (booking != null && booking.Quantity > 1)
                {
                    booking.Quantity--;
                    booking.Amount = booking.Quantity * booking.Price;
                    db.SaveChanges();
                    return booking;
                }
            }
            return null;
        }

        public UserBookings AddBooking(int id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                var booking = db.UserBookings.FirstOrDefault(b => b.Id == id);
                if (booking != null)
                {
                    booking.Quantity++;
                    booking.Amount = booking.Quantity * booking.Price;
                    db.SaveChanges();
                    return booking;
                }
            }
            return null;
        }


    }
}

