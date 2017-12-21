namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberName = c.String(nullable: false, maxLength: 10),
                        MemberEmail = c.String(nullable: false),
                        MemberPhone = c.String(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehiclesParkeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehicleId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RegNo = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Brand = c.String(nullable: false),
                        NoOfWheels = c.Int(nullable: false),
                        CheckInTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CheckOutTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        CheckIn = c.DateTime(nullable: false),
                        Checkout = c.DateTime(nullable: false),
                        VehicleType = c.String(),
                        RegNo = c.String(),
                        TotalTime = c.Time(nullable: false, precision: 7),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehiclesParkeds", "VehicleId", "dbo.VehicleTypes");
            DropForeignKey("dbo.VehiclesParkeds", "MemberId", "dbo.Members");
            DropIndex("dbo.VehiclesParkeds", new[] { "MemberId" });
            DropIndex("dbo.VehiclesParkeds", new[] { "VehicleId" });
            DropTable("dbo.Receipts");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.VehiclesParkeds");
            DropTable("dbo.Members");
        }
    }
}
