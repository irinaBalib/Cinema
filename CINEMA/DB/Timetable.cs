using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CINEMA.DB
{
    public partial class Timetable
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
    }
}
