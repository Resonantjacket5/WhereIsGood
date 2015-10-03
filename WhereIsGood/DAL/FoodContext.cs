using WhereIsGood.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace WhereIsGood.DAL
{
    public class FoodContext : DbContext
    {
        public FoodContext() : base("FoodContext")
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>
            // prevents tables from pluralizing, but i like pluralizing so commented
        }
    }
}
