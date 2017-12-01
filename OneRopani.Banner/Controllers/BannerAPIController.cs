using OneRopani.Banner.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace OneRopani.Banner.Controllers
{
    public class BannerAPIController : ApiController
    {
        public IEnumerable<TheBanner> Get()
        {
            using (BannerDbContext db = new BannerDbContext())
            {
                var list = db.TheBanners.Where(c => DbFunctions.TruncateTime(c.EndDate)
                                       >= DbFunctions.TruncateTime(DateTime.UtcNow));
                return list.ToList();
            }
        }
    }
}
