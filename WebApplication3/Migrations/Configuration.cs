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
                new Shoe {name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'CHICAGO'", prize = 1000},
                new Shoe {name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'UNC'", prize = 1100},
                new Shoe {name = "DIOR X AIR JORDAN 1 HIGH", prize = 1200},
                new Shoe {name = "OFF-WHITE X AIR JORDAN 1 RETRO HIGH OG 'WHITE' 2018", prize = 1122},
                new Shoe {name = "AIR JORDAN 1 RETRO HIGH OG 'FEARLESS'", prize = 1808},
                new Shoe {name = "AIR JORDAN 1 RETRO HIGH OG 'OBSIDIAN'", prize = 1236},
                new Shoe {name = "OFF-WHITE X AIR FORCE 1 LOW '07 'MCA'", prize = 1632},
                new Shoe {name = "OFF-WHITE X AIR FORCE 1 LOW '07 'VOLT'", prize = 1831},
                new Shoe {name = "OFF-WHITE X AIR FORCE 1 LOW 'THE TEN'", prize = 1876},
            };
            shoes.ForEach(s => context.Shoes.AddOrUpdate(p => p.name, s));
            context.SaveChanges();

        }
    }
}
