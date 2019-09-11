using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETIK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EFRepo repo = new EFRepo();
            return View(repo.GetIZDs());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}