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

        public string BookMovie(int movieId, DateTime dt)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
               int selectedTimetable = db.Timetable.FirstOrDefault(t => t.MovieId == movieId && t.StartTime == dt).Id;
                db.UserBookings.Add(new UserBookings()
                {
                  TimetableId = selectedTimetable,
                   Quantity = 1
                });

                db.SaveChanges();
            }
            return null;
        }

        
    }
}

