using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class TheatreScreenMapping
    {
        public int Id { get; set; }
        public int TheatreId { get; set; }
        public int MovieId { get; set; }
        public DateTime MovieDateTime { get; set; }
        public int? BookedSeats { get; set; }
        public int TotalSeats { get; set; }

        public virtual Movie Movie { get; set; } = null!;
        public virtual Theatre Theatre { get; set; } = null!;
    }
}
