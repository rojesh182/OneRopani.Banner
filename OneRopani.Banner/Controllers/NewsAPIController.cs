using OneRopani.Banner.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace OneRopani.Banner.Controllers
{
    public class NewsAPIController : ApiController
    {
        public IEnumerable<News> Get()
        {
            using (BannerDbContext db = new BannerDbContext())
            {
                return db.TheNews.ToList();
            }
        }
    }
}