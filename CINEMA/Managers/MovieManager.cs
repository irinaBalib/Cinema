using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    public class MovieManager
    {

        public List<Movies> GetAllMovies()
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.OrderBy(c => c.Id).ToList();
            }
        }

        public Movies GetMovieInfo(int? id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.FirstOrDefault(m => m.Id == id);
            }
        }

        public List<Movies> GetMoviesByCategory(int categoryId)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.Where(m => m.CategoryId == categoryId).ToList();
            }

        }

        

        //public static string GetCategoryTitle(int id)
        //{
        //    using (CinemaDatabase db = new CinemaDatabase())
        //    {
        //        return db.Categories.FirstOrDefault(c => c.Id == id).Title;
        //    }
        //}
    }
}
