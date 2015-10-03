using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WhereIsGood.Models
{
    public enum Cuisine
    {
        Mexican, Italian, Mediterranean, American, Asian, Vegetarian
    }

    public class Preference
    {
        [Key]
        public int PreferenceID { get; set; }
        public int Distance { get; set; }
        public int GroupID { get; set; }
        public int PersonID { get; set; }
        public Cuisine? Cuisine { get; set; }

        public virtual Group Group { get; set; }
        public virtual Person Person { get; set; }
    }
}
 