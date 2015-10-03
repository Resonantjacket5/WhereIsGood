using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace WhereIsGood.Models
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        // public int Credits { get; set; }


        public virtual ICollection<Preference> Preferences { get; set; }
        //public virtual Preference {  }

        // finds best restaurant based on the Preferences
        public string getBestRestaurant()
        {
            return "best restaurant not implemented";
        }

    }


}
