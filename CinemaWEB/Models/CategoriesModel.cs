using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWEB.Models
{
    public class CategoriesModel
    {
        public List<Categories> ListOfCategories { get; set; }
        public List<Movies> ListOfMovies { get; set; }
        public Categories ActiveCategory { get; set; }
    }
}
