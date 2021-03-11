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
        public List<Timetable> Timetables { get; set; }
        public List<UserBookings> ListOfBooking { get; set; }
        public Movies Movie { get; set; }
     

        public Categories GetCategoryTitle(int id)
        {
            //using (CinemaDatabase db = new CinemaDatabase())
            //{
            //    return db.Categories.FirstOrDefault(c => c.Id == id).Title;
            //}

            return ListOfCategories.FirstOrDefault(c => c.Id == id);
        }
        public  List<Timetable> GetMovieTime(int id)
        {
            //using (CinemaDatabase db = new CinemaDatabase())
            //{
            //    return db.Timetable.Where(t => t.MovieId == id).ToList();
            //}
            return Timetables.Where(t => t.MovieId == id).ToList();
        }
    }
}
