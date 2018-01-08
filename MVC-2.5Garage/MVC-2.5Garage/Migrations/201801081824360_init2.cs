namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VehiclesParkeds", "CheckOutTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehiclesParkeds", "CheckOutTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
