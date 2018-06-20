using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIFAWorldCup2018.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityDescription { get; set; }

        public virtual ICollection<Venue> venueCity { get; set; }
    }
}