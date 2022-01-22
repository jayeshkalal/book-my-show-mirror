using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class Theatre
    {
        public Theatre()
        {
            CityTheatresMappings = new HashSet<CityTheatresMapping>();
            TheatreScreenMappings = new HashSet<TheatreScreenMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CityTheatresMapping> CityTheatresMappings { get; set; }
        public virtual ICollection<TheatreScreenMapping> TheatreScreenMappings { get; set; }
    }
}
