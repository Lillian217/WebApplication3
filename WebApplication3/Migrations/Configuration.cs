namespace WebApplication3.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication3.Models.DatabaseContext context)
        {
            var shoes = new List<Shoe>
            {
                new Shoe{name="OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'CHICAGO'", prize=20},
                new Shoe{name="OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", prize=30},
                new Shoe{name="DIOR X AIR JORDAN 1 HIGH", prize=40},
                new Shoe{name="OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'WHITE' 2018", prize=50},
                new Shoe{name="AIR JORDAN 1 RETRO HIGH OG 'FEARLESS'", prize=60},
                new Shoe{name="AIR JORDAN 1 RETRO HIGH OG 'OBSIDIAN'", prize=20},
                new Shoe{name="OFF-WHITE X AIR FORCE 1 LOW '07 'MCA'", prize=30},
                new Shoe{name="OFF-WHITE X AIR FORCE 1 LOW '07 'VOLT'", prize=40},
                new Shoe{name="OFF-WHITE X AIR FORCE 1 LOW 'THE TEN'", prize=50},
            };
            shoes.ForEach(s => context.Shoes.AddOrUpdate(p => p.prize, s));
            context.SaveChanges();
        }
    }
}
