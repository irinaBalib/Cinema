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
                return db.Movies.OrderBy(c => c.Title).ToList();
            }
        }

        public Movies GetMovieInfo(string title)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());
            }
        }

        public List<Movies> GetMoviesByCategory(int categoryId)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.Where(m => m.CategoryId == categoryId).ToList();
            }
           
        }
    }
}
