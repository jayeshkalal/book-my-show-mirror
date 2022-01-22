using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class Booking
    {
        public string Id { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? MovieTheaterId { get; set; }
        public string? SeatNo { get; set; }
    }
}
