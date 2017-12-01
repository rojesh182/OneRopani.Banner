using System.Data.Entity;

namespace OneRopani.Banner.Models
{
    public class BannerDbContext : DbContext
    {
        public BannerDbContext() : base("connString")
        {
        }
        public DbSet<TheBanner> TheBanners { get; set; }
        public DbSet<News> TheNews { get; set; }
        public DbSet<AdModel> AdModels { get; set; }
    }
}