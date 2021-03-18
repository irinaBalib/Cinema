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

        public string BookMovie(int id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                db.UserBookings.Add(new UserBookings()
                {
                    TimetableId = id,
                    Quantity = 1
                });
                db.SaveChanges();
            }
            return null;
        }

        public UserBookings RemoveBooking (int id)
        {
            using(CinemaDatabase db = new CinemaDatabase())
            {
                var booking = db.UserBookings.FirstOrDefault(b => b.Id == id);
                if (booking != null)
                {
                    db.UserBookings.Remove(booking);
                    db.SaveChanges();
                    return booking;
                }
            }
            return null;
        }
    }
}

