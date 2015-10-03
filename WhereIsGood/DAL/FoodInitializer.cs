using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhereIsGood.Models;

namespace WhereIsGood.DAL
{
    // initializes data base table
    public class FoodInitializer : System.Data.Entity. DropCreateDatabaseAlways<FoodContext>
    {
        protected override void Seed(FoodContext context)
        {
            //base.Seed(context);
        }
    }
}