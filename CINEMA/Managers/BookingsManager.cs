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

        public void BookMovie(Timetable t)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                db.UserBookings.Add(new UserBookings()
                {
                    TimetableId = t.Id,
                   Quantity = 1
                });

                db.SaveChanges();
            }
        }

        
    }
}

