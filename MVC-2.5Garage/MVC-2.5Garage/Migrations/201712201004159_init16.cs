namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init16 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VehiclesParkeds", "TotalTime");
            DropColumn("dbo.VehiclesParkeds", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehiclesParkeds", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.VehiclesParkeds", "TotalTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
