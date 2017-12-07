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
            AutomaticMigrationsEnabled = false;
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
                new Text { Name = "InfoOneHand" , Content = "This is your info text about blades, handles and reelseats.One-Hand"},
                new Text { Name = "InfoTwoHand", Content = "This is your info text about blades, handles and reelseats. Two-hand" },
                new Text { Name = "AboutText" , Content = "This is your text about."},
                new Text { Name = "ContactText" , Content = "This is your contact information"}
            );
            
            context.Blades.AddOrUpdate(
                b => b.Name,
                new Blade { Name = "Blade1", Price = 1500, Weight = 670, Image = "Klinga1.png" },
                new Blade { Name = "Blade2", Price = 1350, Weight = 700, Image = "Klinga2.png" },
                new Blade { Name = "Blade3", Price = 1600, Weight = 600, Image = "Klinga3.png" },
                new Blade { Name = "Blade4", Price = 1500, Weight = 670, Image = "Klinga1.png" },
                new Blade { Name = "Blade5", Price = 1350, Weight = 700, Image = "Klinga2.png" },
                new Blade { Name = "Blade6", Price = 1600, Weight = 600, Image = "Klinga3.png" },
                new Blade { Name = "Blade7", Price = 1500, Weight = 670, Image = "Klinga1.png" },
                new Blade { Name = "Blade8", Price = 1350, Weight = 700, Image = "Klinga2.png" },
                new Blade { Name = "Blade9", Price = 1600, Weight = 600, Image = "Klinga3.png" }
            );

            context.Handles.AddOrUpdate(
                h => h.Name,
                new Handle { Name = "Handle1", Price = 450, Weight = 67, Image = "Korkhandtag1.png" },
                new Handle { Name = "Handle2", Price = 550, Weight = 73, Image = "Korkhandtag2.png" },
                new Handle { Name = "Handle3", Price = 700, Weight = 70, Image = "Korkhandtag3.png" },
                new Handle { Name = "Handle4", Price = 450, Weight = 67, Image = "Handtagtvahands1.png" },
                new Handle { Name = "Handle5", Price = 550, Weight = 73, Image = "Handtagtvahands2.png" },
                new Handle { Name = "Handle6", Price = 700, Weight = 70, Image = "Handtagtvahands3.png" }
            );

            context.ReelSeats.AddOrUpdate(
                r => r.Name,
                new ReelSeat { Name = "ReelSeat1", Price = 1100, Weight = 170, Image = "Rullfaste1.png" },
                new ReelSeat { Name = "ReelSeat2", Price = 900, Weight = 150, Image = "Rullfaste2.png" },
                new ReelSeat { Name = "ReelSeat3", Price = 700, Weight = 160, Image = "Rullfaste3.png" },
                new ReelSeat { Name = "ReelSeat4", Price = 1100, Weight = 170, Image = "RullfasteAlu.png" },
                new ReelSeat { Name = "ReelSeat5", Price = 900, Weight = 150, Image = "RullfasteDarkWood.png" },
                new ReelSeat { Name = "ReelSeat6", Price = 700, Weight = 160, Image = "RullfasteGold.png" },
                new ReelSeat { Name = "ReelSeat7", Price = 1100, Weight = 170, Image = "RullfasteLightWood.png" },
                new ReelSeat { Name = "ReelSeat9", Price = 700, Weight = 160, Image = "RullfasteRed.png" }
            );

            context.Accessories.AddOrUpdate(
                a => a.Name,
                new Accessory { Name = "Case1", Price = 100, Weight = 100, Image = "Case1.png", Type = Models.Accessory.AccessoryType.Case },
                new Accessory { Name = "Case2", Price = 100, Weight = 100, Image = "Case2.png", Type = Models.Accessory.AccessoryType.Case },
                new Accessory { Name = "Case3", Price = 100, Weight = 100, Image = "Case3.png", Type = Models.Accessory.AccessoryType.Case },
                new Accessory { Name = "Holder1", Price = 100, Weight = 100, Image = "Holder1.png", Type = Models.Accessory.AccessoryType.Holder },
                new Accessory { Name = "RodTube1", Price = 100, Weight = 100, Image = "RodTube1.png", Type = Models.Accessory.AccessoryType.RodTube },
                new Accessory { Name = "RodTube2", Price = 100, Weight = 100, Image = "RodTube2.png", Type = Models.Accessory.AccessoryType.RodTube },
                new Accessory { Name = "RodTube3", Price = 100, Weight = 100, Image = "RodTube3.png", Type = Models.Accessory.AccessoryType.RodTube }
            );


        }
    }
}
