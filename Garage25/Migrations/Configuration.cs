namespace Garage25.Migrations
{
    using Garage25.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage25.Models.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Garage25.Models.GarageContext";
        }

        protected override void Seed(Garage25.Models.GarageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Members.AddOrUpdate(
              //p => p.Surname, s=>s.Lastname,
              new Member { Surname="Carson", 
                          Lastname="Alexander" },
              new Member { Surname="Meredith", 
                          Lastname="Alonso" },
              new Member { Surname="Arturo", 
                          Lastname="Anand" },
                new Member { Surname="Gytis", 
                          Lastname="Barzdukasr" }
            );     
            context.Vehicles.AddOrUpdate(
                new Vehicle {RegistrationNumber= "afg134", Color ="Red", Brand="Volvo", Model="240dl", WheelCount=4, ParkTime = 2016-01-27 11:59:55},
                new Vehicle { RegistrationNumber = "afg553", Color = "Blue", Brand = "BMV", Model = "4332dl", WheelCount = 4, ParkTime = 2016-01-27 11:59:55 },
                new Vehicle { RegistrationNumber = "faf134", Color = "Black", Brand = "Renault", Model = "240dl", WheelCount = 4, ParkTime = 2016-01-27 11:59:55 },
                new Vehicle { RegistrationNumber = "dff545", Color = "Red", Brand = "Saab", Model = "ae45dl", WheelCount = 6, ParkTime = 2016-01-27 11:59:55 },
                new Vehicle { RegistrationNumber = "af764", Color = "White", Brand = "Volvo", Model = "240dl", WheelCount = 4, ParkTime = 2016-01-27 11:59:55 }
                );
            context.VehicleTypes.AddOrUpdate(
                new VehicleType{Type="Car"},
                new VehicleType{Type="Bus"},
                new VehicleType{Type="Boat"},
                new VehicleType{Type="Airplane"},
                new VehicleType{Type="Motorcycle"}                
                );
        }       
    }
}
