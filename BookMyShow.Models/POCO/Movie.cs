using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class Movie
    {
        public Movie()
        {
            TheatreScreenMappings = new HashSet<TheatreScreenMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Cast { get; set; }

        public virtual ICollection<TheatreScreenMapping> TheatreScreenMappings { get; set; }
    }
}
