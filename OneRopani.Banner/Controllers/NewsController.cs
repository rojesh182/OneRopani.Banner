using OneRopani.Banner.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace OneRopani.Banner.Controllers
{
    public class NewsController : Controller
    {
        private BannerDbContext db = new BannerDbContext();

        public ActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddNews(News data)
        {
            if (ModelState.IsValid)
            {
                db.TheNews.Add(new News()
                {
                    Title = data.Title,
                    AddedDate = data.AddedDate,
                    NewsContent = data.NewsContent
                });
                db.SaveChanges();
            }
            return RedirectToAction("DisplayNews");
        }

        public ActionResult DisplayNews()
        {
            return View(db.TheNews.ToList());
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.TheNews.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            News news = db.TheNews.Find(id);
            db.TheNews.Remove(news);
            db.SaveChanges();
            return RedirectToAction("DisplayNews");
        }
    }
}