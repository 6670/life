using LifeInsuranceDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeInsuranceDeal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [WhitespaceFilter]
        public ActionResult Index()
        {
            FilterModel model = new FilterModel();
            return View(model);
        }
        [WhitespaceFilter]
        public ActionResult Privacy()
        {
            FilterModel model = new FilterModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(FilterModel model)
        {
            if (ModelState.IsValid)
            {

                TempData["FilterModel"] = model;
                return RedirectToAction("Index", "Form");
            }
            return View(model);
        }
        [WhitespaceFilter]
        public ActionResult ContactUs()
        {
            return View();
        }
        [WhitespaceFilter]
       public ActionResult CoverLife()
        {
                       return View();
        }
        [WhitespaceFilter]

        public ActionResult Assurance()
        {
            return View();
        }
        [WhitespaceFilter]

        public ActionResult LifeForFamily()
        {
            return View();
        }
        [WhitespaceFilter]

        public ActionResult InsuranceCalculator()
        {
            return View();
        }
        [WhitespaceFilter]

        public ActionResult WholeLife()
        {
            return View();
        }
        [WhitespaceFilter]

        public ActionResult TermLife()
        {
            return View();
        }
        [WhitespaceFilter]

        public ActionResult LifeOver50()
        {
            return View(); 
        }
        [WhitespaceFilter]

        public ActionResult CriticalIllness()
        {
            return View();
        }
        [WhitespaceFilter]
        public ActionResult MortgageLife()
        {
            FilterModel model = new FilterModel();
            model.ProductType = "Mortgage Life Insurance";

            return View(model);
        }
    }
}