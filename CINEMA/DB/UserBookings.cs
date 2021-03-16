using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CINEMA.DB
{
    public partial class UserBookings
    {
      public int Id { get; set; }
        public int TimetableId { get; set; }
        public int Quantity { get; set; }

    }
}
