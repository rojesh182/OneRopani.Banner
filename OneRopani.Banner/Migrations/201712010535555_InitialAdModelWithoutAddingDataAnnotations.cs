namespace OneRopani.Banner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAdModelWithoutAddingDataAnnotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PropertyType = c.String(),
                        TransactionType = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        TotalPrice = c.Long(nullable: false),
                        UnitPrice = c.Long(nullable: false),
                        Ropani = c.Int(nullable: false),
                        Aana = c.Int(nullable: false),
                        Daam = c.Int(nullable: false),
                        Paisa = c.Int(nullable: false),
                        HouseArea = c.Int(nullable: false),
                        NoOfFloors = c.Int(nullable: false),
                        BedRoom = c.Int(nullable: false),
                        LivingRoom = c.Int(nullable: false),
                        Kitchen = c.Int(nullable: false),
                        DiningRoom = c.Int(nullable: false),
                        District = c.String(),
                        Municipality = c.String(),
                        Location = c.String(),
                        WardNo = c.Int(nullable: false),
                        Tole = c.String(),
                        RoadWith = c.Single(nullable: false),
                        DistanceFromMainRoad = c.Single(nullable: false),
                        ContactName = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        PhoneNo = c.Int(nullable: false),
                        MobileNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdModels");
        }
    }
}
