namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receipts", "VehicleType", c => c.String());
            DropColumn("dbo.Receipts", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Receipts", "Type", c => c.String());
            DropColumn("dbo.Receipts", "VehicleType");
        }
    }
}
