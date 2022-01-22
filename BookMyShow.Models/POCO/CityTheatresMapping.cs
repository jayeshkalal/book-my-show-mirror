using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class CityTheatresMapping
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int TheatreId { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual Theatre Theatre { get; set; } = null!;
    }
}
