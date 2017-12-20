namespace MVC_2._5Garage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receipts", "MemberName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Receipts", "MemberName");
        }
    }
}
