using CINEMA.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWEB.Models
{
    public class MovieModel
    {
        public Movies ActiveMovie { get; set; }
        public Categories MovieCategory { get; set; }
    
        public List<Timetable> AvailableTimetables { get; set; }

       
        [Display(Name = "Please select time")]
        public int? SelectedTimeId { get; set; }

    }
}
