using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
namespace WorldBestCafe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Secret()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult OrderHistory()
        {
            OrderDataProvider odp = new OrderDataProvider();
            ViewBag.Orders = odp.Get();
            return View();
        }

        public ActionResult Menu()
        {
            MenuProvider mp = new MenuProvider();
            ViewBag.Menu =(string[])mp.Get();
            return View();
        }
    }
}