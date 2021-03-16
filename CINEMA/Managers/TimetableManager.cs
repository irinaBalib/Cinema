using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    public class TimetableManager
    {

        public Timetable GetTimetable(int movieId, DateTime dt)
        {
            using (var db = new CinemaDatabase())
            {
                return db.Timetable.FirstOrDefault(t => t.MovieId == movieId && t.StartTime == dt);
            }
        }

        public List<DateTime> GetMovieTimes(int? id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                List<DateTime> movieTimes = new List<DateTime> { };
                foreach (var t in db.Timetable)
                {
                    if (t.MovieId == id)
                    {
                        movieTimes.Add(t.StartTime);
                    }
                }
                return movieTimes;
            }
        }
    }
}
