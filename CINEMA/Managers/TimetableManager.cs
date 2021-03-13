using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    public class TimetableManager
    {

        public Timetable GetTimetableId(int movieId, DateTime dt)
        {
            using (var db = new CinemaDatabase())
            {
                return db.Timetable.FirstOrDefault(t => t.MovieId == movieId && t.StartTime == dt);
            }
        }
    }
}
