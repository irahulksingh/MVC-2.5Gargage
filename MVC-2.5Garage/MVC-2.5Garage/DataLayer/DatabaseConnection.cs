using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_2._5Garage.DataLayer
{
    public class DatabaseConnection:DbContext
    {

        public DatabaseConnection() : base("Parkinglot") { }

        public System.Data.Entity.DbSet<MVC_2._5Garage.Models.Members> Members { get; set; }
        public System.Data.Entity.DbSet<MVC_2._5Garage.Models.VehiclesParked> VehiclesParked { get; set; }
        public System.Data.Entity.DbSet<MVC_2._5Garage.Models.VehicleTypes> VehiclesType { get; set; }

        public System.Data.Entity.DbSet<MVC_2._5Garage.Models.ViewModel.Receipt> Receipts { get; set; }
    }
}