using System;
using System.Collections.Generic;

namespace BookMyShow.Models.POCO
{
    public partial class City
    {
        public City()
        {
            CityTheatresMappings = new HashSet<CityTheatresMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;

        public virtual ICollection<CityTheatresMapping> CityTheatresMappings { get; set; }
    }
}
