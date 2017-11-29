namespace CaseRod.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CaseRod.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CaseRod.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CaseRod.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Database.Delete();

            context.Texts.AddOrUpdate(
                t => t.Name,
                new Text { Name = "InfoText", Content = "LoremIpsum" },
                new Text { Name = "AboutText", Content = "esbhfjkdfnsdf" },
                new Text { Name = "ContactText", Content = "aghsfnjkdsdfdfsdfjhfd" }
            );
            
            context.Blades.AddOrUpdate(
                b => b.Name,
                new Blade { Name = "Blade1", Price = 1500, Weight = 670, Image = "Klinga1.png" },
                new Blade { Name = "Blade2", Price = 1350, Weight = 700, Image = "Klinga2.png" },
                new Blade { Name = "Blade3", Price = 1600, Weight = 600, Image = "Klinga3.png" }
            );

            context.Handles.AddOrUpdate(
                h => h.Name,
                new Handle { Name = "Handle1", Price = 450, Weight = 67, Image = "Korkhandtag1.png" },
                new Handle { Name = "Handle2", Price = 550, Weight = 73, Image = "Korkhandtag2.png" },
                new Handle { Name = "Handle3", Price = 700, Weight = 70, Image = "Korkhandtag3.png" }
            );

            context.ReelSeats.AddOrUpdate(
                r => r.Name,
                new ReelSeat { Name = "ReelSeat1", Price = 1100, Weight = 170, Image = "Rullfaste1.png" },
                new ReelSeat { Name = "ReelSeat2", Price = 900, Weight = 150, Image = "Rullfaste2.png" },
                new ReelSeat { Name = "ReelSeat3", Price = 700, Weight = 160, Image = "Rullfaste3.png" }
            );


        }
    }
}
