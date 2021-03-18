using CINEMA.DB;
using CINEMA.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWEB.Models
{
    public class UserBookingsModel
    {
        public List<UserBookings> ListOfBookings { get; set; }
        public UserBookings Booking { get; set; }
        public Movies Movie (int id)
        {
            MovieManager mm = new MovieManager();
            return mm.GetMovieByTimetableId(id);
        }

        public DateTime StartTime(int id)
        {
            TimetableManager tm = new TimetableManager();
            return tm.GetStartTime(id);
        }
    }
}
