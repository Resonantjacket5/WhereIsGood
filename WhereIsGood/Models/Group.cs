﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WhereIsGood.Models
{
    public class Group
    {
        // if uncommented requires manually entering in ID number
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int GroupID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
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
