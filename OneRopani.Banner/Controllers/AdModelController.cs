using OneRopani.Banner.Models;
using System.Linq;
using System.Web.Mvc;

namespace OneRopani.Banner.Controllers
{
    public class AdModelController : Controller
    {
        private BannerDbContext db = new BannerDbContext();

        public ActionResult Index()
        {
            return View(db.AdModels.ToList());
        }
    }
}