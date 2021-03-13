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

        public List<Movies> GetMoviesByCategory(int CategoryId)
        {
            using (var db = new CinemaDatabase())
            {
                return db.Movies.Where(m => m.CategoryId == CategoryId).OrderByDescending(m => m.Title).ToList();
            }
        }
        public Movies GetMovieById(int? id)
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.FirstOrDefault(m => m.Id == id);
            }
        }

    }
}
