using OneRopani.Banner.Models;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OneRopani.Banner.Controllers
{
    public class TheBannerController : Controller
    {
        private BannerDbContext db = new BannerDbContext();

        public ActionResult Index()
        {
            var list = db.TheBanners.Where(c => DbFunctions.TruncateTime(c.EndDate)
                                       > DbFunctions.TruncateTime(DateTime.UtcNow));
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase postedFile, TheBanner theBanner)
        {
            string path = Server.MapPath("~/Images/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            postedFile.SaveAs(path + Path.GetFileName(postedFile.FileName));

            db.TheBanners.Add(new TheBanner()
            {
                Title = theBanner.Title,
                Path = ("~/Images/" + Path.GetFileName(postedFile.FileName)),
                BannerUrl = theBanner.BannerUrl,
                StartDate = theBanner.StartDate,
                EndDate = theBanner.EndDate
            });
            db.SaveChanges();
 
            return RedirectToAction("TheList");
        }

        public ActionResult TheList()
        {
            return View(db.TheBanners.ToList());
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheBanner theBanner = db.TheBanners.Find(id);
            if (theBanner == null)
            {
                return HttpNotFound();
            }
            return View(theBanner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Path,Title,BannerUrl,StartDate,EndDate")] TheBanner theBanner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theBanner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TheList");
            }
            return View(theBanner);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheBanner theBanner = db.TheBanners.Find(id);
            if (theBanner == null)
            {
                return HttpNotFound();
            }
            return View(theBanner);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TheBanner theBanner = db.TheBanners.Find(id);
            db.TheBanners.Remove(theBanner);
            db.SaveChanges();
            return RedirectToAction("TheList");
        }

       protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}