namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_2._5Garage.DataLayer.DatabaseConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC_2._5Garage.DataLayer.DatabaseConnection";
        }

        protected override void Seed(MVC_2._5Garage.DataLayer.DatabaseConnection context)
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

            //For parked vehicles

            context.VehiclesParked.AddOrUpdate(n => n.RegNo, new Models.VehiclesParked()
            {
                RegNo = "xyz123",
                Model = "Tesla",
                Brand = "Puma",
                NoOfWheels = 4,
            });

            // for members

            context.Members.AddOrUpdate(m => m.Id, new Models.Members()
            {
                MemberName = "Rahul",
                MemberEmail = "abc@red.com",
                MemberPhone = "123456789",

            });

            //for vehicles

            context.VehiclesType.AddOrUpdate(v => v.Id, new Models.VehicleTypes()
            {
                VehicleType = "Car",
            });

          
        }
    }
}
