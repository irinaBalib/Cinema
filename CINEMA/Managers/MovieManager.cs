using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    class MovieManager
    {

        public List<Movies> GetAllMovies()
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Movies.OrderBy(c => c.Title).ToList();
            }
        }
    }
}
