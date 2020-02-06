using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormulaireIntervention.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New_Client()
        {
            ViewBag.Message = "Nouveau Client";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Intervention()
        {
            ViewBag.Message = "Intervention";

            return View();
        }
        public ActionResult Resume()
        {
            ViewBag.Message = "Résumé";
            return View();
        }
        public ActionResult Client_Sign()
        {
            ViewBag.Message = "Signature Client";

            return View();
        }
    }
}