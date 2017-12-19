namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VehiclesParkeds", "Members_Id", "dbo.Members");
            DropIndex("dbo.VehiclesParkeds", new[] { "Members_Id" });
            RenameColumn(table: "dbo.VehiclesParkeds", name: "Members_Id", newName: "MemberId");
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.VehiclesParkeds", "VehicleId", c => c.Int(nullable: false));
            AlterColumn("dbo.VehiclesParkeds", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.VehiclesParkeds", "VehicleId");
            CreateIndex("dbo.VehiclesParkeds", "MemberId");
            AddForeignKey("dbo.VehiclesParkeds", "VehicleId", "dbo.VehicleTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VehiclesParkeds", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehiclesParkeds", "MemberId", "dbo.Members");
            DropForeignKey("dbo.VehiclesParkeds", "VehicleId", "dbo.VehicleTypes");
            DropIndex("dbo.VehiclesParkeds", new[] { "MemberId" });
            DropIndex("dbo.VehiclesParkeds", new[] { "VehicleId" });
            AlterColumn("dbo.VehiclesParkeds", "MemberId", c => c.Int());
            DropColumn("dbo.VehiclesParkeds", "VehicleId");
            DropTable("dbo.VehicleTypes");
            RenameColumn(table: "dbo.VehiclesParkeds", name: "MemberId", newName: "Members_Id");
            CreateIndex("dbo.VehiclesParkeds", "Members_Id");
            AddForeignKey("dbo.VehiclesParkeds", "Members_Id", "dbo.Members", "Id");
        }
    }
}
