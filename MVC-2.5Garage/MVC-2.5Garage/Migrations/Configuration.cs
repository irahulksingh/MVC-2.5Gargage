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

            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-123",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "La-456",
                    Brand = "Mercedes",
                    Model = "Old Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-777",
                    Brand = "TurboJet",
                    Model = "Speedy Rahul",
                    NoOfWheels = 10,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-456",
                    Brand = "Citroen",
                    Model = "Old Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-789",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "LA-123",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "LA-234",
                    Brand = "Citroen",
                    Model = "Old Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-345",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-389",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-985",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "La-713",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "LA-923",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-152",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-382",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-163",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-193",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-283",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-134",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-127",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-103",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-102",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-723",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-613",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });
            context.VehiclesParked.AddOrUpdate(p => p.RegNo,
                new Models.VehiclesParked
                {
                    RegNo = "NY-823",
                    Brand = "Citroen",
                    Model = "New Age",
                    NoOfWheels = 4,
                });


            context.Members.AddOrUpdate(m => m.Id,
                new Models.Members
                {
                    MemberName = "Rahul Singh ",
                    MemberEmail = "rs@gmail.com ",
                    MemberPhone = "+123456676734 ",
                    Address = "NY, Avenue22 224242",
                });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Shabnan Singh ",
                  MemberEmail = "ss@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              }); context.Members.AddOrUpdate(m => m.Id,
               new Models.Members
               {
                   MemberName = "Deidre Singh",
                   MemberEmail = "rs@gmail.com ",
                   MemberPhone = "+123456676734 ",
                   Address = "NY, Avenue22 224242",
               });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",
              });
            context.Members.AddOrUpdate(m => m.Id,
              new Models.Members
              {
                  MemberName = "Rahul Singh ",
                  MemberEmail = "rs@gmail.com ",
                  MemberPhone = "+123456676734 ",
                  Address = "NY, Avenue22 224242",

              });
            context.VehiclesType.AddOrUpdate(v => v.Id,
                new Models.VehicleTypes
                {
                    VehicleType = "Car",
                });
                  
        }
    }
}
