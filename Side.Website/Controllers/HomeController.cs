using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Side.Website.Context;
using Side.Website.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Side.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebsiteDBContext DB;
        private IConfiguration Config;
        public HomeController(ILogger<HomeController> logger, WebsiteDBContext db,IConfiguration config)
        {
            this.DB = db;
            this._logger = logger;
            this.Config = config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.GraduateStatus = DB.GraduateStatuses.ToList();
            ViewBag.JuryList = DB.Juries.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    DB.Persons.Add(person);
                    DB.SaveChanges();
                    //TODO this'll come from a service. Yazılacak servisten tek methodla çek!
                    var senderEmail = new MailAddress(Config.GetValue<string>("MailSettings:SenderMail"),Config.GetValue<string>("MailSettings:SenderDisplayName"));
                    var receiverEmail = new MailAddress(Config.GetValue<string>("MailSettings:ReceiverMail"), Config.GetValue<string>("MailSettings:ReceiverDisplayName"));
                    var password = Config.GetValue<string>("MailSettings:SenderPass");
                    var sub = person.PersonName + " " + person.PersonSurname;
                    var body = person.PersonID + "-" + person.PersonName + " " + person.PersonSurname;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = sub,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    } 
                }

                ViewBag.GraduateStatus = DB.GraduateStatuses.ToList();
                ViewBag.JuryList = DB.Juries.ToList();
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.GraduateStatus = DB.GraduateStatuses.ToList();
                ViewBag.JuryList = DB.Juries.ToList();
                ViewBag.Error = ex.Message;
                return View();
            }  
        } 
    }
}
