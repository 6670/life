using LifeInsuranceDeal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSeearchMediaService;

namespace LifeInsuranceDeal.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        private readonly CaptureService _captureService = new CaptureService();

        [WhitespaceFilter]
        public ActionResult Index()
        {
            if (TempData.ContainsKey("FilterModel"))
            {
                TempData.Keep();
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult Index(CompleteFormModel model)
        {
            if (ModelState.IsValid)
            {
                FilterModel filData = TempData["FilterModel"] as FilterModel;

                var Dob = DateTime.Parse(SqlDateTime.MinValue.ToString());
                if (model.Day != 0 && model.Month != 0 && model.Year != 0)
                {
                    var daysOfMonth = DateTime.DaysInMonth(model.Year, model.Month);
                    if (daysOfMonth < model.Day)
                    {
                        model.Day = daysOfMonth;
                    }
                    Dob = new DateTime(model.Year, model.Month, model.Day);
                }
                LifeLead lead = new LifeLead()
                {
                    Address = model.Address,
                    City = string.Empty,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    GeneratedDateTime = DateTime.Now,
                    HomePhone = model.HomePhone,
                    Source = Session["Source"] as string ?? null,
                    Keyword = Session["Keyword"] as string ?? null,
                    MatchType = Session["Match"] as string ?? null,
                    IpAddress = Session["RemoteIPAddress"] as string ?? null,
                    LastName = model.LastName,
                    PostCode = model.PostCode,
                    ProductName = "Life",
                    SiteId = 1,
                    Status = "New",
                    Title = model.Title,
                    WorkPhone = model.HomePhone ?? model.WorkPhone,
                    CoverAmount = filData.CoverAmount,
                    CoverPeriod = filData.CoverPeriod,
                    ProductType = filData.ProductType,
                    Smoker = model.Smoker,
                    SingleOwnership = filData.SingleOwnership,
                    DOB = Dob,
                    Age = CalculateAge(Dob)

                };
                
               // var id = _captureService.NewAdminLeadCapture(lead, "http://localhost:3431/dataConverstion/capture");

               var id = _captureService.NewAdminLeadCapture(lead, "https://api.websearchmedia.co.uk/dataConverstion/capture");
              //  var id = _captureService.NewAdminLeadCapture(lead, "");
                if (id > 0)
                {
                    TempData["LeadId"] = id;

                }else
                {

                }
                return RedirectToAction("Index", "Thank");
            }
            return View();
        }
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = DateTime.Now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
            return age;
        }
    }
}