using System;
using System.Collections.Generic;
using System.Web;

namespace WhereIsGood.Models
{
    public enum PriceLevel
    {
        Cheap, Frugal, Casual, Rich, Fancy
    }

    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PriceLevel? PriceLevel { get; set; }
        //public DateTime PreferenceDate { get; set; }

        public virtual ICollection<Preference> Preferences { get; set; }
        //public virtual Preference {  }
    }
}
