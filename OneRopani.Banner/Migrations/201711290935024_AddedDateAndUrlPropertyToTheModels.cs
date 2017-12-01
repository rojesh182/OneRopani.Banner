namespace OneRopani.Banner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateAndUrlPropertyToTheModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TheBanners", "BannerUrl", c => c.String(nullable: false));
            AddColumn("dbo.News", "AddedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "AddedDate");
            DropColumn("dbo.TheBanners", "BannerUrl");
        }
    }
}
