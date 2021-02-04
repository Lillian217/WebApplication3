using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DatabaseInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var shoes = new List<Shoe>
            {
                new Shoe{name="test1", prize=20},
                new Shoe{name="test2", prize=30},
                new Shoe{name="test3", prize=40},
                new Shoe{name="test4", prize=50},
                new Shoe{name="test5", prize=60},
            };
            shoes.ForEach(s => context.Shoes.Add(s));
            context.SaveChanges();
        }
    }
}