using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CINEMA.Managers
{
    public class CategoryManager
    {
        public List<Categories> GetAllCategories()
        {
            using (CinemaDatabase db = new CinemaDatabase())
            {
                return db.Categories.OrderBy(c => c.Title).ToList();
            }
        }
    }
}
