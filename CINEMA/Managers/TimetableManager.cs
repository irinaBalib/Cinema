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

        public List<Timetable> GetMovieTimetable(int? id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Timetable.Where(t => t.MovieId == id.Value).ToList();
            }
        }

        public DateTime GetStartTime (int id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Timetable.FirstOrDefault(t => t.Id == id).StartTime;
            }
        }
    }
}
