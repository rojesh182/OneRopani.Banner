using OneRopani.Banner.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace OneRopani.Banner.Controllers
{
    public class SaveAdAPIController : ApiController
    {
        private BannerDbContext db;

        public SaveAdAPIController()
        {
            db = new BannerDbContext();
            //db.Configuration.ProxyCreationEnabled = false;
        }

        public HttpResponseMessage PostSaveAd(AdModel adModel)
        {
            if (ModelState.IsValid)
            {
                db.AdModels.Add(adModel);
                db.SaveChanges();

                try
                {
                    WebMail.SmtpServer = "smtp.gmail.com";
                    WebMail.SmtpPort = 587;
                    WebMail.SmtpUseDefaultCredentials = true;
                    WebMail.EnableSsl = true;
                    //EmailId used to send emails from application  
                    WebMail.UserName = "ramaron16@gmail.com";
                    WebMail.Password = "";

                    //Sender email address.  
                    WebMail.From = "ramaron16@gmail.com";

                    //Send email  
                    WebMail.Send(to: "rojesh182@gmail.com", subject: adModel.ContactName +" "+"has posted a new Ad.", body: adModel.Title +" "+ adModel.ContactName +" "+ adModel.Address +" "+ adModel.MobileNo + " at " + DateTime.Now + ".", isBodyHtml: true);
                }
                catch (Exception)
                {
                    HttpResponseMessage msg = Request.CreateResponse("Problem while sending email, Please check details.");
                    return msg;
                }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, adModel);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = adModel.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

    }
}