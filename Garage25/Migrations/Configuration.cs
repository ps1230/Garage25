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
              new Member
              {
                  MemberId = 1,
                  Surname = "Carson",
                  Lastname = "Alexander",
                  Address = "Adreji, 110",
                  TelephoneNo = "38740189"
              },
              new Member
              {
                  MemberId = 2,
                  Surname = "Meredith",
                  Lastname = "Alonso",
                  Address = "akljdsfer 3455",
                  TelephoneNo = "9348957"
              },
              new Member
              {
                  MemberId = 3,
                  Surname = "Arturo",
                  Lastname = "Anand",
                  Address = "kdjfad,4859",
                  TelephoneNo = "39859458"
              },
                new Member
                {
                    MemberId = 4,
                    Surname = "Gytis",
                    Lastname = "Barzdukasr",
                    Address = "jfadöd, 8493",
                    TelephoneNo = "487524075"
                }
            );

            context.VehicleTypes.AddOrUpdate(
                new VehicleType { VehicleTypeId = 1, Type = "Car" },
                new VehicleType { VehicleTypeId = 2, Type = "Bus" },
                new VehicleType { VehicleTypeId = 3, Type = "Boat" },
                new VehicleType { VehicleTypeId = 4, Type = "Airplane" },
                new VehicleType { VehicleTypeId = 5, Type = "Motorcycle" }
                );

            DateTime currentTime = DateTime.Now;
            context.Vehicles.AddOrUpdate(
                new Vehicle { RegistrationNumber = "afg134", Color = "Red", Brand = "Volvo", Model = "240dl", WheelCount = 4, ParkTime = currentTime, MemberId = 1, VehicleTypeId = 1 },
                new Vehicle { RegistrationNumber = "afg553", Color = "Blue", Brand = "BMV", Model = "4332dl", WheelCount = 4, ParkTime = currentTime, MemberId = 2, VehicleTypeId = 3 },
                new Vehicle { RegistrationNumber = "faf134", Color = "Black", Brand = "Renault", Model = "240dl", WheelCount = 4, ParkTime = currentTime, MemberId = 3, VehicleTypeId = 5 },
                new Vehicle { RegistrationNumber = "dff545", Color = "Red", Brand = "Saab", Model = "ae45dl", WheelCount = 6, ParkTime = currentTime, MemberId = 4, VehicleTypeId = 2 },
                new Vehicle { RegistrationNumber = "af764", Color = "White", Brand = "Volvo", Model = "240dl", WheelCount = 4, ParkTime = currentTime, MemberId = 1, VehicleTypeId = 4 }
                );
        }
    }
}
