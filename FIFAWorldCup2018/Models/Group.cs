using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIFAWorldCup2018.Models
{
    public class Group
    {
        public int Id { get; set; }
        public char GroupName { get; set; }
        public virtual ICollection<Team> TeamsGroup { get; set; }

    }
}