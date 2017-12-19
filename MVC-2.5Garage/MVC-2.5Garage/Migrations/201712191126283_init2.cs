namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VehiclesParkeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                        RegNo = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Brand = c.String(nullable: false),
                        NoOfWheels = c.Int(nullable: false),
                        CheckInTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CheckOutTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VehiclesParkeds");
        }
    }
}
