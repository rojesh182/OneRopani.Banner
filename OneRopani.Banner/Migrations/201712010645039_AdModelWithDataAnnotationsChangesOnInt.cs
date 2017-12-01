namespace OneRopani.Banner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdModelWithDataAnnotationsChangesOnInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdModels", "TotalPrice", c => c.Long());
            AlterColumn("dbo.AdModels", "UnitPrice", c => c.Long());
            AlterColumn("dbo.AdModels", "Aana", c => c.Int());
            AlterColumn("dbo.AdModels", "Daam", c => c.Int());
            AlterColumn("dbo.AdModels", "Paisa", c => c.Int());
            AlterColumn("dbo.AdModels", "HouseArea", c => c.Int());
            AlterColumn("dbo.AdModels", "NoOfFloors", c => c.Int());
            AlterColumn("dbo.AdModels", "BedRoom", c => c.Int());
            AlterColumn("dbo.AdModels", "LivingRoom", c => c.Int());
            AlterColumn("dbo.AdModels", "Kitchen", c => c.Int());
            AlterColumn("dbo.AdModels", "DiningRoom", c => c.Int());
            AlterColumn("dbo.AdModels", "WardNo", c => c.Int());
            AlterColumn("dbo.AdModels", "MobileNo", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdModels", "MobileNo", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "WardNo", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "DiningRoom", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "Kitchen", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "LivingRoom", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "BedRoom", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "NoOfFloors", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "HouseArea", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "Paisa", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "Daam", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "Aana", c => c.Int(nullable: false));
            AlterColumn("dbo.AdModels", "UnitPrice", c => c.Long(nullable: false));
            AlterColumn("dbo.AdModels", "TotalPrice", c => c.Long(nullable: false));
        }
    }
}
