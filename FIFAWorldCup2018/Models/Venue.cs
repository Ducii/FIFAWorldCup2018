using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIFAWorldCup2018.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string VenueName { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<City> CityVenue { get; set; }
    }
}