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
        public Timetable? SelectedTimetable { get; set; }
        public List<DateTime> AvailableTime { get; set; }

        [Required]
        [Display(Name = "Please select time")]
        public DateTime? SelectedTime { get; set; }

    }
}
