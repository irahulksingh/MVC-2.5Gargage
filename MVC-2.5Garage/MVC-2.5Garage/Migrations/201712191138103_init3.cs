namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VehiclesParkeds", "Members_Id", c => c.Int());
            CreateIndex("dbo.VehiclesParkeds", "Members_Id");
            AddForeignKey("dbo.VehiclesParkeds", "Members_Id", "dbo.Members", "Id");
            DropColumn("dbo.VehiclesParkeds", "VehicleType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VehiclesParkeds", "VehicleType", c => c.String());
            DropForeignKey("dbo.VehiclesParkeds", "Members_Id", "dbo.Members");
            DropIndex("dbo.VehiclesParkeds", new[] { "Members_Id" });
            DropColumn("dbo.VehiclesParkeds", "Members_Id");
        }
    }
}
