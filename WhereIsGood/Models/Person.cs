using System;
using System.Collections.Generic;
using System.Web;

namespace WhereIsGood.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        //public DateTime PreferenceDate { get; set; }

        public virtual ICollection<Preference> Preferences { get; set; }
        //public virtual Preference {  }
    }
}
