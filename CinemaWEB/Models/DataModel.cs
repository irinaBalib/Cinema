using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWEB.Models
{
    public class DataModel
    {
        public List<Categories> ListOfCategories { get; set; }
        public List<Movies> ListOfMovies { get; set; }
        public List<DateTime> MovieTimes { get; set; }
        public List<UserBookings> ListOfBooking { get; set; }
        public Categories ActiveCategory { get;set; }
        public Movies ActiveMovie { get; set; }
        public string CategoryTitle { get; set; }
        public Timetable SelectedMovie { get; set; }

    }
}
