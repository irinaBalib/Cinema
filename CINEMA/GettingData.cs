using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA
{
    public  class GettingData
    {

      public List<Categories> ListOfCategories { get; set; }
        public List<Movies> ListOfMovies { get; set; }
        public List<Timetable> Timetables { get; set; }
        public List<UserBookings> ListOfBooking { get; set; }
        public Movies Movie { get; set; }

        public static string GetCategoryTitle(int id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Categories.FirstOrDefault(c => c.Id == id).Title;
            }
        }
    }
}
