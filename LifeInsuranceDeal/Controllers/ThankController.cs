using LifeInsuranceDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeInsuranceDeal.Controllers
{
    public class ThankController : Controller
    {
        // GET: Thnak
        [WhitespaceFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}