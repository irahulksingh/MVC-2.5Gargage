namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VehiclesParkeds", "TotalTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VehiclesParkeds", "TotalTime");
        }
    }
}
